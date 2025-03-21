using Microsoft.Identity.Client;
using System.Security.Cryptography;

namespace StudentRegInlämning
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {

            Terminal terminal = new Terminal();

            while (true) 
            {
                terminal.PrintMenu();
                int menuInput = Convert.ToInt32(Console.ReadLine());
                terminal.HandleMenuInput(menuInput);
            }
            



        }

       
    }
}
