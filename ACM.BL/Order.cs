﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderID = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
