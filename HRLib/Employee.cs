namespace HRLib
{
    public abstract class Employee

    {
		private string name;

		public string Name
		{ 
			get { return name; }
			set { name = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}
		static int count;
		private int empNo;

		static Employee()
		{
			count = 100;
		}
		public int EmpNo
		{
			get { return empNo; }
			set { empNo = value; }
		}

		public Employee()
		{
			Name = "Neha Sawant";
			Address = "Moshi,Pune";
			count++;
			EmpNo = count;


		}

		public Employee(string name, string address):this()
		{
			Name = name;
			Address = address;
		}
		public abstract double CalculateSalary();
		
	}
}
