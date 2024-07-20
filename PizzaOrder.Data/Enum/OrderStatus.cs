using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder.Domain.Enum
{
    public enum OrderStatus
    {
        Created = 1,
        InKitchen=2,
        OnTheWay=3,
        Delivered=4,
        Canceled=5,

    }
}
