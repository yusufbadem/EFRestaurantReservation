using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantReservation.Models;
public class Customer:BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string EMail { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }


}
