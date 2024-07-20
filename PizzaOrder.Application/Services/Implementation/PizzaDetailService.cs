using PizzaOrder.Application.Services.Interface;
using PizzaOrder.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder.Application.Services.Implementation
{
    public class PizzaDetailService:IPizzaDetailService
    {
        private readonly PizzaDBContext _dbContext;
        public PizzaDetailService(PizzaDBContext dBContext)
        {
            _dbContext = dBContext;
        }
    }
}
