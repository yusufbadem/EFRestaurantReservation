using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurantReservation.Models;
public class Order:BaseEntity
{
    public DateTime OrderDate { get; set; }
    public int Quantity { get; set; }

    public int ReservationId { get; set; }
    [ForeignKey("ReservationId")]
    public Reservation Reservation { get; set; }

    public int MenuId { get; set; }

    [ForeignKey("MenuId")]
    public Menu Menu { get; set; }
}
