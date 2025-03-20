using Microsoft.Identity.Client;
using System.Security.Cryptography;

namespace StudentRegInlämning
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {

            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseStudentReg;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

            //var Students = new List<Student>();
            //Students.Add(s1);

            Terminal terminal = new Terminal();

            
            terminal.PrintMenu();
            int menuInput = Convert.ToInt32(Console.ReadLine());
            terminal.HandleMenuInput(menuInput);



        }

       
    }
}
