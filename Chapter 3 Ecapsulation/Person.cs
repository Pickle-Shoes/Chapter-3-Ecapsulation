using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
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
            _name = name;
            _emailAddress = email;
        }

        public Person(string name, string email, int age, string phone)
        {
            _name = name;
            _emailAddress = email;
            _age = age;
            _phoneNumber = phone;
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

    }
}
