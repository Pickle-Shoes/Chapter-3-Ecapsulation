using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter_3_Ecapsulation
{
    internal class Person
    {
        //fields/ Atrributes
        private string _name;
        private string _emailAddress;
        private int _age;
        private string _phoneNumber;

        //constructor
        public Person(string name, string email)
        {
            Name = name;
            EmailAddress = email;
        }

        public Person(string name, string email, int age, string phone)
        {
            Name = name;
            EmailAddress = email;
            Age = age;
            PhoneNumber = phone;
        }

        //properties

        public string Name
        {
            get { return _name;}
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name must not be Null.");
                }
                    _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set 
            {
                if (value >= 8)
                    _age = value;
                else
                    throw new Exception("Need to be 8 or older to use this app");
            }
        }

        public string EmailAddress
        {
            get { return _emailAddress; }

            set 
            {
                if (Regex.IsMatch(value, "^[\\w\\-\\.]+@([\\w-]+\\.)+[\\w-]{2,}$"))
                {
                    _emailAddress = value;
                }
                else
                {
                    throw new Exception("Not a valid email");
                }
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }

            set 
            {
                //make sure phone number is valid


                if(Regex.IsMatch(value, "^\\(?([0-9]{3})\\)?[-.\\s]?([0-9]{3})[-.\\s]?([0-9]{4})$"))
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new Exception("invalid fomatted phone number");
                }
            }



        }
    }
}
