using PizzaOrder.Domain.Entities;
using PizzaOrder.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder.Domain.Data
{
    public static class DataSeeder
    {
        public static void EnsureDataSeeding(this PizzaDBContext pizzaDBContext)
        {
            if (!pizzaDBContext.OrderDetails.Any())
            {
                pizzaDBContext.OrderDetails.AddRange(new List<EOrderDetails>
                {
                    new EOrderDetails("Pipalbot","Baneshowr","9816946400",100),
                    new EOrderDetails("AOne Cafe","Old-Banehswor","9816946401",150),
                    new EOrderDetails("BijayChowk","Gaushala","9816946402",200),
                    new EOrderDetails("Airport Gate 1","Sinamangal","9816946403",300),
                    new EOrderDetails("Birtamode","Jhapa","9816946404",400),
                });
                pizzaDBContext.SaveChanges();
            }

            if (!pizzaDBContext.PizzaDetails.Any())
            {
                pizzaDBContext.PizzaDetails.AddRange(new List<EPizzaDetails>
                {
                    new EPizzaDetails("Birtamode Pizza",Toppings.ExtraCheese | Toppings.Onions, 200,11,1),
                    new EPizzaDetails("Birtamode Special Pizza",Toppings.Bacon| Toppings.Sausage, 200,11,1),
                    new EPizzaDetails("Birtamode Hot Pizza",Toppings.ExtraCheese | Toppings.Onions, 300,11,1),
                    new EPizzaDetails("Birtamode Veg Pizza",Toppings.ExtraCheese | Toppings.Pepperoni, 100,11,1),
                    new EPizzaDetails("Birtamode Naglo Pizza",Toppings.Sausage | Toppings.Onions, 400,11,1)
                });
            }
        }
    }
}
