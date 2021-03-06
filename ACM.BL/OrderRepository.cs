﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 7, 21, 14, 10, 10, new TimeSpan(-7, 0, 0));
            }
            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
