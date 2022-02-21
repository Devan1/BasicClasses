using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    public class Car
    {
        //Constructors
        public Car()
        {

        }
        public Car(string input_Make, string input_Model, int input_Year)
        {
            make = input_Make;
            model = input_Model;
            year = input_Year;
        }
        //Fields
        //Properties
        //Methods
        public string make { get; set; } //get = read set = write
        public string model { get; set; }
        public int year { get; set; }
    }
}
