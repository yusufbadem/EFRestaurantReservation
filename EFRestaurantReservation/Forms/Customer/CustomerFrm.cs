using EFRestaurantReservation.Models;
using EFRestaurantReservation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFRestaurantReservation.Forms;
public partial class CustomerFrm : Form
{
    public CustomerFrm()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            Customer customer = new Customer();
            customer.Name = txtName.Text.Trim();
            customer.Surname = txtSurname.Text.Trim();
            customer.EMail = txtEmail.Text;
            customer.Phone = txtPhone.Text;
            customer.Address = txtAddress.Text;


            CustomerServices customerServices = new CustomerServices();
            customerServices.AddCustomer(customer);
            MessageBox.Show(customer.Name + "" + customer.Surname + "" + "Kişisi Eklendi");
            LoadCustomers();
        }
        catch (Exception ex)
        {

            MessageBox.Show("Kişi Eklenemedi Lütfen Bilgileri Dogru giriniz " + ex);
        }



    }

    private void CustomerFrm_Load(object sender, EventArgs e)
    {
        LoadCustomers();

    }

    private void LoadCustomers()
    {
        CustomerServices customerServices = new CustomerServices();
        List<Customer> customerList = customerServices.GetAllCustomers();

        dgvCustomer.DataSource = customerList;
    }



    private void btnDelete_Click(object sender, EventArgs e)
    {
        int SelectedRow = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["Id"].Value);

        CustomerServices customerServices = new CustomerServices();

        customerServices.DeleteCustomer(SelectedRow);

        LoadCustomers();

    }

    private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    //    EFRestaurantReservationContext context = new EFRestaurantReservationContext();
    //    int SelectedId = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["Id"].Value);
    //    Customer customer = context.Customers.FirstOrDefault(x => x.Id == SelectedId);

        //txtName.Text = customer.Name;
        //txtSurname.Text = customer.Surname;
        //txtEmail.Text = customer.EMail;
        //txtPhone.Text = customer.Phone;
        //txtAddress.Text = customer.Address;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {

            EFRestaurantReservationContext context = new EFRestaurantReservationContext();
            int SelectedId = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["Id"].Value);
            Customer customer = context.Customers.FirstOrDefault(x => x.Id == SelectedId);

            customer.Name = txtName.Text.Trim();
            customer.Surname = txtSurname.Text.Trim();
            customer.EMail = txtEmail.Text.Trim();
            customer.Phone = txtPhone.Text.Trim();
            customer.Address = txtAddress.Text.Trim();

            CustomerServices customerServices = new CustomerServices();
            customerServices.UpdateCustomer(customer);

            LoadCustomers();
        }
        catch (Exception ex)
        {

            MessageBox.Show("Hata Oluştu Lütfen Tekrar deneyiniz");
        }
    }

    private void dgvCustomer_DoubleClick(object sender, EventArgs e)
    {

        EFRestaurantReservationContext context = new EFRestaurantReservationContext();
        int SelectedId = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["Id"].Value);
        Customer customer = context.Customers.FirstOrDefault(x => x.Id == SelectedId);


        txtName.Text = customer.Name;
        txtSurname.Text = customer.Surname;
        txtEmail.Text = customer.EMail;
        txtPhone.Text = customer.Phone;
        txtAddress.Text = customer.Address;

        /*
         * Aynı kişiden varsa güncelleme
         * bool IsCustomerExist = txtName.Text == context.Customers.Where(x => x.Name == customer.Name && x.Surname==customer.Surname).ToString();

        if (!IsCustomerExist)
        {
            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            txtEmail.Text = customer.EMail;
            txtPhone.Text = customer.Phone;
            txtAddress.Text = customer.Address;
        }
        else
        {
            MessageBox.Show("Bu Müşteriden var");
        }
       
         */

    }
}
