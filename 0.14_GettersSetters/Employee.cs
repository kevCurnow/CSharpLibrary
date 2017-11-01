using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_GettersSetters
{
    class Employee
    {
        //"Backing" Fields
        private int _id;
        private string _name;
        private string _workQuote;

        //Properties
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                
                if (value < 0)
                    throw new Exception("The employee ID is invalid");
                _id = value;
            }
        }

        
        public string Name
        {
            get { return _name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("You must enter an employee name");
                _name = value.Trim();
            }
        }

        //Methods
        public void SetWorkQuote(string quote)
        {
            this._workQuote = quote;
        }

        public string GetQuote()
        {
            return this._workQuote;
        }

    }
}
