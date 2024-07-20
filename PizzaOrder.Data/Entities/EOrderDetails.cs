using PizzaOrder.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder.Domain.Entities
{
    public class EOrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string AddressLine1 { get; set; }
        [Required]
        [StringLength(40)]
        public string AddressLine2 { get; set; }
        [Required]
        [StringLength(10)]
        public string MobileNumber { get; set; }
        public List<EPizzaDetails> PizzaDetails { get; set; }
        public decimal Amount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public OrderStatus OrderStatus { get; set; }


        public EOrderDetails()
        {

        }

        public EOrderDetails(string addressLine1, string addressLine2, string mobileNumber, int amount)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            MobileNumber = mobileNumber;
            Amount = amount;
            Date = DateTime.Now;
            OrderStatus = OrderStatus.Created;
        }
    }
}
