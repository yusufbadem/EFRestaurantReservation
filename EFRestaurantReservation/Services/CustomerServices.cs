using EFRestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantReservation.Services;
public class CustomerServices
{

    public Customer AddCustomer(Customer customer)
    {
        EFRestaurantReservationContext context =new EFRestaurantReservationContext();

        context.Customers.Add(customer);
        context.SaveChanges();

        return customer;

    }

    public List<Customer> GetAllCustomers()
    {
        EFRestaurantReservationContext context=new EFRestaurantReservationContext();    

        List<Customer> customers =context.Customers.ToList();
        return customers;

    }

    public Customer GetById(int id)
    {
        EFRestaurantReservationContext ctx=new EFRestaurantReservationContext();

        return ctx.Customers.FirstOrDefault(c=>c.Id==id);
    }

    public void DeleteCustomer(int id)
    {
        EFRestaurantReservationContext context = new EFRestaurantReservationContext();

        Customer customer = context.Customers.FirstOrDefault(x => x.Id == id);

        context.Customers.Remove(customer);
        context.SaveChanges();
    }

    public void UpdateCustomer(Customer selectedCustomer)
    {
        EFRestaurantReservationContext context=new EFRestaurantReservationContext();

        Customer customer=context.Customers.FirstOrDefault(x=>x.Id== selectedCustomer.Id);

        if (customer !=null)
        {
            customer.Name = selectedCustomer.Name;
            customer.Surname = selectedCustomer.Surname;
            customer.Address = selectedCustomer.Address;
            customer.EMail = selectedCustomer.EMail;
            customer.Phone = selectedCustomer.Phone;
        }

        context.Customers.Update(customer);
        context.SaveChanges();
      
    }
}
