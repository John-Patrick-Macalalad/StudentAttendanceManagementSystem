using System;
using System.Collections.Generic;

namespace StudentAttendanceManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Start:
            Console.Clear();

            Console.WriteLine("|==========================================|");
            Console.WriteLine("|                 LOG IN                   |");
            Console.WriteLine("|==========================================|");

            string user, pass;
            Console.WriteLine("Enter your username: ");
            user = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter you password: ");
            pass = Convert.ToString(Console.ReadLine());
            if (user == "admin" && pass == "12345")
            {
                Console.WriteLine("|==========================================|");
                Console.WriteLine("|           Logged in Succesfully          |");
                Console.WriteLine("|==========================================|");
                Console.WriteLine("");
                Console.WriteLine("Press Enter again to go the Menu. ");
            }
            else
            {
                Console.WriteLine("Log in failed");
                Console.ReadLine();
                goto Start;
            }
            
            Console.ReadLine();

            
            MainMenu();

        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|               The Main Menu              |");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("Please type the specific number to enter.");
            Console.WriteLine("");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Class");
            Console.WriteLine("3. Add Staff");
            Console.WriteLine("4. View Student Enrolled");
            Console.WriteLine("5. Exit");

            string myoptions;
            myoptions = Console.ReadLine();

            switch (myoptions)
            {
                case "1":
                    AddStud();
                    break;
                case "2":
                    AddClass();
                    break;
                case "3":
                    AddStaff();
                    break;
                case "4":
                    ViewEnrolled();
                    break;
                case "5":
                    Exit();
                    break;

            }

            MainMenu();

        }

        static void AddStud()
        {
            
            string[] studName = new string[20];
            string[] studCourse = new string[20];
            
            int n;
            Console.WriteLine("");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|              ADD  A STUDENT              |");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("How many students that you want to add? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Student Name: ");
                studName[i] = Console.ReadLine();
                Console.WriteLine("Enter Student Course: ");
                studCourse[i] = Console.ReadLine();

            }

            Console.WriteLine("");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|           Successfully Added!!!          |");
            Console.WriteLine("|==========================================|");

            for (int j = 0; j < n; j++)
            {
                
                Console.WriteLine("Student Name Added is: " + studName[j]);
                Console.WriteLine("Student Course Added is: " + studCourse[j]);
                
            }

            Console.ReadLine();

        }
        static void AddClass()
        {
            string[] studClass = new string[20];

            int n;
            Console.WriteLine("");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|               ADD  A CLASS               |");
            Console.WriteLine("|==========================================|");
            
            Console.WriteLine("How many Class you want to add? ");
            n = int.Parse(Console.ReadLine());

            for (int c = 0; c < n; c++)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Class Name: ");
                studClass[c] = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|            Succesfully Added!!!          |");
            Console.WriteLine("|==========================================|");


            for (int s = 0; s < n; s++)
            {
                
                Console.WriteLine("The Class Name is: " + studClass[s]);
                
            }

            Console.ReadLine();
        }
        static void AddStaff()
        {
            string[] staffName = new string[20];

            int n;
            Console.WriteLine("");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|                ADD A STAFF               |");
            Console.WriteLine("|==========================================|");

            Console.WriteLine("How many staff you want to add? ");
            n = int.Parse(Console.ReadLine());

            for (int s = 0; s < n; s++)
            {
                Console.WriteLine("Enter Staff Name: ");
                staffName[s] = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|             Successfully Added!!!        |");
            Console.WriteLine("|==========================================|");

            for (int t = 0; t < n; t++)
            {
                
                Console.WriteLine("Staff Name added is: " + staffName[t]);
            }

            Console.ReadLine();
        }

        static void ViewEnrolled()
        {
            List<string> viewStud = new List<string>();

            Console.WriteLine("");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|             STUDENTS ENROLLED            |");
            Console.WriteLine("|==========================================|");

            viewStud.Add("1. Adrian Alejandre");
            viewStud.Add("2. Angela Cabaroc");
            viewStud.Add("3. Angeliko Centeno");
            viewStud.Add("4. Franz Maaba");
            viewStud.Add("5. James Darel Advincula");
            viewStud.Add("6. John Patrick Macalalad");
            viewStud.Add("7. Kian Magdamit");
            viewStud.Add("8. Kristian Paul Enore");

            foreach (string student in viewStud)
            {
                Console.WriteLine( student );
                
            }
            Console.ReadLine();
        }
        static void Exit()
        {
            Console.WriteLine("Press ENTER to leave ");
            Console.ReadLine();
            System.Environment.Exit(1);

      
        }

    }
}
