using PizzaOrder.Application.Services.Interface;
using PizzaOrder.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder.Application.Services.Implementation
{
    public class OrderDetailService:IOrderDetailService
    {
        private readonly PizzaDBContext _dbContext;

        public OrderDetailService(PizzaDBContext pizzaDBContext)
        {
            _dbContext = pizzaDBContext;
        }
    }
}
