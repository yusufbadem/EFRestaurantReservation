using EFRestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantReservation.Services;
public class ReservationServices
{
    public void GetAll()
    {
        EFRestaurantReservationContext context = new EFRestaurantReservationContext();

        List<Customer> nameSurname=context.Customers.ToList();
    }

    public Reservation  AddReservation(Reservation reservation)
    {
        EFRestaurantReservationContext context=new EFRestaurantReservationContext();

        context.Reservations.Add(reservation);
        context.SaveChanges();
        return reservation;
    }


}
