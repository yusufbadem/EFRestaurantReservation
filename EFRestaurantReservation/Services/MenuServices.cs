using EFRestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantReservation.Services;
public class MenuServices
{
    public Menu AddMEnu(Menu menu)
    {
        EFRestaurantReservationContext context = new EFRestaurantReservationContext();

        context.Add(menu);
        context.SaveChanges();

        return menu;

    }

    public List<Menu> GetAllMenu()
    {
       EFRestaurantReservationContext context= new EFRestaurantReservationContext();
       
        List<Menu> menus = context.Menus.ToList();
        return menus;
    }

    public void DeleteMenu(int id)
    {
        EFRestaurantReservationContext context = new EFRestaurantReservationContext();

       Menu menu = context.Menus.FirstOrDefault(x => x.Id == id);

        context.Menus.Remove(menu);
        context.SaveChanges();
    }
}
