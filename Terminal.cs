using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegInlämning
{
    internal class Terminal
    {
        Register register = new Register();

        public void PrintMenu()
        {
            Console.WriteLine("\nVälj vilket ett av följande alternativ i menyn:" +
                "\n[1] Registrera en ny student" +
                "\n[2] Ändra en student" +
                "\n[3] Lista alla studenter");
        }

        public void HandleMenuInput(int input)
        {
            if (input == 1)
            {
                Console.WriteLine("Du har valt att registrera en ny student");
                register.RegNewStu();
            }
            else if (input == 2)
            {
                Console.WriteLine("Du har valt att ändra en student");
                register.ChangeStudent();
            }
            else if (input == 3)
            {
                Console.WriteLine("Du har valt att lista alla studenter");
                register.ListAllStu();
            }
            else
            {
                Console.WriteLine("Du måste skriva en siffra mellan 1-3");
            }

        }

    }
}
