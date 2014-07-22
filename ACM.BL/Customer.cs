using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.customerID = customerId;
        }

        public static int InstanceCount { get; set; }

        private string _lastName;

        public string LastName 
        { 
            get 
            {
                return _lastName;
            }
            set 
            {
                _lastName = value;
            }
        }

        public string firstName { get; set; }

        public string eMailAddress { get; set; }

        public int customerID { get; private set; }

        public string FullName  
        { 
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += firstName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(eMailAddress)) isValid = false;
            return isValid;
        }

    }
}
