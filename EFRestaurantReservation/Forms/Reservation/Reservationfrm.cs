using EFRestaurantReservation.Models;
using EFRestaurantReservation.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFRestaurantReservation.Forms.Reservation;
public partial class Reservationfrm : Form
{
    public Reservationfrm()
    {
        InitializeComponent();
    }

    private void cmbNameSurname_SelectedIndexChanged(object sender, EventArgs e)
    {
        //EFRestaurantReservationContext context = new EFRestaurantReservationContext();

        //var customerNameSurname = from item in context.Customers
        //                          select new { item.Id, NameSurname = item.Name + " " + item.Surname };

        //cmbNameSurname.DataSource = customerNameSurname.ToList();
        //cmbNameSurname.DisplayMember = "NameSurname";
        //cmbNameSurname.ValueMember = "Id";

    }

    private void Reservationfrm_Load(object sender, EventArgs e)
    {
        FillTheCombobox();
        FillDataGrid();

    }

    private void FillDataGrid()
    {
        EFRestaurantReservationContext context = new EFRestaurantReservationContext();
        List<EFRestaurantReservation.Models.Reservation> reservation = context.Reservations.ToList();

        dgvReservation.DataSource = reservation;
    }

    private void FillTheCombobox()
    {
        EFRestaurantReservationContext context = new EFRestaurantReservationContext();
        cmbNameSurname.DataSource = context.Customers.ToList();

        var customerNameSurname = from item in context.Customers
                                  select new { item.Id, NameSurname = item.Name + " " + item.Surname };

        cmbNameSurname.DataSource = customerNameSurname.ToList();
        cmbNameSurname.DisplayMember = "NameSurname";
        cmbNameSurname.ValueMember = "Id";
    }

    private void btnAddReservation_Click(object sender, EventArgs e)
    {
        EFRestaurantReservation.Models.Reservation reservation = new Models.Reservation();
        EFRestaurantReservationContext context = new EFRestaurantReservationContext();
        //cmbNameSurname.DataSource=context.Customers.ToList();
        //cmbNameSurname.DisplayMember= "Name";
        //cmbNameSurname.ValueMember="Id";
        CustomerServices customerServices = new CustomerServices();
        int selectedId=Convert.ToInt32(cmbNameSurname.SelectedValue);
        Customer customer=customerServices.GetById(selectedId);



        //var selectedValue = from item in context.Customers
        //                    select new { item.Id };

        //reservation.CustomerId = context.Customers.First(x=> cmbNameSurname.ValueMember==selectedValue);
        //reservation.NameSurname = cmbNameSurname.Text;
        //reservation.AddDate = dtpDate.Value;
        //reservation.Notes = txtNotes.Text;


        reservation.ReservationDate = dtpDate.Value;
        reservation.CustomerId=customer.Id;
        reservation.NameSurname=customer.Name;
        reservation.Notes = txtNotes.Text;

        ReservationServices reservationServices = new ReservationServices();

        reservationServices.AddReservation(reservation);

        MessageBox.Show("Reservasyon Başarı İle Eklendi");
        FillDataGrid();

    }

    private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dgvReservation_DoubleClick(object sender, EventArgs e)
    {

    }
}
