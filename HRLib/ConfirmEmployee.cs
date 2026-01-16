using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        private double basic;

        public double Basic
        {
            get { return basic; }
            set {
                if (value < 5000){
                    throw new BasicException("Minimum 5000 required");
                }
                else {
                    basic = value;
                }
            }
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public ConfirmEmployee()
        {
            Basic = 10000;
            Designation = "Developer";

        }

        public ConfirmEmployee(double basic, string designation,string name,string address):base(name,address)
        {
            Basic = basic;
            Designation = designation;
        }

        public override string ToString()
        {
            return $"Your account number is : {this.EmpNo}";
        }
        public sealed override double CalculateSalary()
        {
            if (Basic >= 30000)
            {
                return basic + (0.3 * basic) + (0.3 * basic) - (0.1 * basic);
                
            }
            if (Basic >= 20000)
            {
                return basic + (0.2 * Basic) + (0.2 * Basic) - (0.1 * Basic);
            }



            else
            {
                return basic + (0.1 * Basic) + (0.1 * Basic) - (0.1 * Basic);
            }


        }
    }
}
