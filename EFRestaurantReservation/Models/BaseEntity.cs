using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantReservation.Models;
public class BaseEntity
{
    public int Id { get; set; }
    public DateTime AddDate { get; set; }=DateTime.Now;
}
