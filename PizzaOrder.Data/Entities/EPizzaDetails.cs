using PizzaOrder.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder.Domain.Entities
{
    public class EPizzaDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        public Toppings Toppings{ get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public int OrderDetailsId{ get; set; }

        public EPizzaDetails()
        {
            
        }
        public EPizzaDetails(string name, Toppings toppings, decimal price, int size, int OderedDetailsID)
        {
            Name = name;
            Toppings = toppings;
            Price = price;
            Size = size;
            OrderDetailsId = OderedDetailsID;
        }

    }
}
