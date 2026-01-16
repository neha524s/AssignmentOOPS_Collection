using HRLib;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConfirmEmployee e = new ConfirmEmployee(20000, "Dev", "Neha", "Pune");
                Console.WriteLine($"Your Netsalary is : {e.CalculateSalary()}");
                Console.WriteLine(e.ToString());

                ConfirmEmployee e1 = new ConfirmEmployee(45000, "Dev", "Neha", "Pune");
                Console.WriteLine($"Your Netsalary is : {e1.CalculateSalary()}");
                Console.WriteLine(e1.ToString());

                ConfirmEmployee e2 = new ConfirmEmployee(10000000, "Dev", "Neha", "Pune");
                Console.WriteLine($"Your Netsalary is : {e2.CalculateSalary()}");
                Console.WriteLine(e2.ToString());
            }
            catch (BasicException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Trainee t = new Trainee();
            Console.WriteLine($"Your total Pay is : {t.CalculateSalary()}");
            Console.WriteLine();

        }
    }
}
