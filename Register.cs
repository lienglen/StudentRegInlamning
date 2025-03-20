using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegInlämning
{
    internal class Register
    {
        StudentDbContext dbCtx = new StudentDbContext();//Detta är själva databaskopplingen för EF. Instans av StudentDbContext för att få med allt som finns i den klassen.
        public void RegNewStu()
        {
            Console.WriteLine("Fyll i studentens förnamn: ");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Fyll i studentens efternamn: ");
            string? lastName = Console.ReadLine();
            Console.WriteLine("Fyll i studentens stad");
            string? city = Console.ReadLine();

            var s1 = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                City = city

            };

            dbCtx.Add(s1);//lägger till studenten i DBSetet som finns i klassen StudentDbContext
            dbCtx.SaveChanges();
        }

        public void ChangeStudent()
        {
            Console.WriteLine("Vilken student vill du ändra? Ange Student-ID med en siffra");
            int studentChoice = Convert.ToInt32(Console.ReadLine());

            if (studentChoice != 0) 
            {
                Console.WriteLine("Vad vill du ändra? Välj ett av följande alterativ:" +
               "\n[1] Förnamnet" +
               "\n[2] Efternamnet" +
               "\n[3] Staden");

                int changeChoice = Convert.ToInt32(Console.ReadLine());

                switch (changeChoice)
                {
                   case 1:
                       
                        var std1 = dbCtx.Students.Where(s => s.StudentId == studentChoice).FirstOrDefault<Student>();

                        Console.WriteLine("Skriv in det rätta förnamnet:");
                        std1.FirstName = Console.ReadLine();
                        dbCtx.SaveChanges();
                        return;

                        case 2:
                        var std2 = dbCtx.Students.Where(s => s.StudentId == studentChoice).FirstOrDefault<Student>();

                        Console.WriteLine("Skriv in det rätta efternamnet:");
                        std2.LastName = Console.ReadLine();
                        dbCtx.SaveChanges();
                        return;

                        case 3:
                        var std3 = dbCtx.Students.Where(s => s.StudentId == studentChoice).FirstOrDefault<Student>();

                        Console.WriteLine("Skriv in den rätta staden:");
                        std3.City = Console.ReadLine();
                        dbCtx.SaveChanges();
                        return;
                    default:
                        Console.WriteLine("Vänligen välj ett av alternativen 1-3");
                        return;
                }

            }

        }

        public void ListAllStu()
        {

            foreach (var item in dbCtx.Students)
            {
                Console.WriteLine($"\nStudent-Id:\n{item.StudentId}\nFörnamn:\n{item.FirstName}\nEfternamn:\n{item.LastName}\nStad:\n{item.City}\n\n");
            }

            dbCtx.SaveChanges();
        }
    }
}
