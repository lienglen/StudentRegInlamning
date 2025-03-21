using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegInlämning
{
    public class Register
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
            Console.WriteLine($"Du har registrerat följande:\nFörnamn: {firstName}\nEfternamn: {lastName}\nStad: {city}");
        }

        public void ChangeStudent(int studentChoice)
        {
            var std = dbCtx.Students.Where(s => s.StudentId == studentChoice).FirstOrDefault<Student>();
            Console.WriteLine($"Stundenten du har valt är {std.StudentId} {std.FirstName} {std.LastName} {std.City}");

            Console.WriteLine("Skriv in din ändring:");
            std.FirstName = Console.ReadLine();

            Console.WriteLine($"Studenten är nu registrerad som: {std.StudentId} {std.FirstName} {std.LastName} {std.City}");
            dbCtx.SaveChanges();
            
        }

        public void ChangeStudentChoice()
        {
            Console.WriteLine("Vilken student vill du ändra? Ange Student-ID med en siffra:");
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

                        //var std1 = dbCtx.Students.Where(s => s.StudentId == studentChoice).FirstOrDefault<Student>();
                        //Console.WriteLine($"Stundenten du har valt är {std1.StudentId} {std1.FirstName} {std1.LastName} {std1.City}");
                        //Console.WriteLine("Skriv in det rätta förnamnet:");
                        //std1.FirstName = Console.ReadLine();
                        //dbCtx.SaveChanges();
                        ChangeStudent(changeChoice);
                        return;

                        case 2:
                        //var std2 = dbCtx.Students.Where(s => s.StudentId == studentChoice).FirstOrDefault<Student>();
                        //Console.WriteLine($"Stundenten du har valt är {std2.StudentId} {std2.FirstName} {std2.LastName} {std2.City}");
                        //Console.WriteLine("Skriv in det rätta efternamnet:");
                        //std2.LastName = Console.ReadLine();
                        //dbCtx.SaveChanges();
                        ChangeStudent(changeChoice);
                        return;

                        case 3:
                        //var std3 = dbCtx.Students.Where(s => s.StudentId == studentChoice).FirstOrDefault<Student>();
                        //Console.WriteLine($"Stundenten du har valt är {std3.StudentId} {std3.FirstName} {std3.LastName} {std3.City}");
                        //Console.WriteLine("Skriv in den rätta staden:");
                        //std3.City = Console.ReadLine();
                        //dbCtx.SaveChanges();
                        ChangeStudent(changeChoice);
                        return;
                    default:
                        Console.WriteLine("Vänligen välj ett av alternativen 1-3");
                        return;
                }

            }
            else
            {
                Console.WriteLine("Det finns ingen student med detta id. Försök igen.");
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
