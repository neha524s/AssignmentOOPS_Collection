using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee:Employee
    {
		private int noofdays;

		public int NoOfDays
		{
			get { return noofdays; }
			set { noofdays = value; }
		}

		private double ratePerDay;

		public double RatePerDay
		{
			get { return ratePerDay; }
			set { ratePerDay = value; }
		}

		public Trainee()
		{
			NoOfDays = 5;
			RatePerDay = 500;
		}

		public Trainee(string name,string address,int noofdays, double ratePerDay) : base(name, address)
		{
			NoOfDays = noofdays;
			RatePerDay = ratePerDay;
		}

        public override string ToString()
        {
            return base.ToString();
        }
        public sealed override double CalculateSalary()
        {
			return NoOfDays * RatePerDay;
        }
    }
}
