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
public partial class MenuFrm : Form
{
    public MenuFrm()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            //EFRestaurantReservationContext context = new EFRestaurantReservationContext();

            Menu menu = new Menu();
            menu.Title = txtTitle.Text.Trim();
            menu.Description = txtDescription.Text.Trim();
            menu.Price = Convert.ToDecimal(txtPrice.Text.Trim());

            MenuServices menuServices = new MenuServices();
            menuServices.AddMEnu(menu);
            MessageBox.Show("Menu Başarıyla Kaydedildi");
            LoadMenu();
        }
        catch (Exception ex)
        {

            MessageBox.Show("Yanlış İşlem lütfen tekrar deneyiniz " + ex);
        }


    }

    private void MenuFrm_Load(object sender, EventArgs e)
    {
        LoadMenu();
    }

    private void LoadMenu()
    {
        MenuServices menuServices = new MenuServices();

        List<Menu> menuList = menuServices.GetAllMenu();
        dgvMenu.DataSource = menuList;
    }

    private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        EFRestaurantReservationContext context=new EFRestaurantReservationContext();
        int SelectedRow = Convert.ToInt32(dgvMenu.CurrentRow.Cells["Id"].Value);

        MenuServices menuServices = new MenuServices();

        menuServices.DeleteMenu(SelectedRow);
        MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
        LoadMenu();
    }
}
