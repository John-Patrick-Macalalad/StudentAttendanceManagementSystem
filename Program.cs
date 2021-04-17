﻿using System;

namespace StudentAttendanceManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Start:
            Console.Clear();

            Console.WriteLine("==========================================");
            Console.WriteLine("LOG IN");
            Console.WriteLine("==========================================");

            string user, pass;
            Console.WriteLine("Enter your username: ");
            user = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter you password: ");
            pass = Convert.ToString(Console.ReadLine());
            if (user == "admin" && pass == "12345")
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("Logged in Succesfully");
                Console.WriteLine("==========================================");
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
            Console.WriteLine("==========================================");
            Console.WriteLine("The Main Menu");
            Console.WriteLine("==========================================");
            Console.WriteLine("Please type the specific number to enter.");
            Console.WriteLine("");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Classroom");
            Console.WriteLine("3. Add Staff");
            Console.WriteLine("4. Exit");

            string myoptions;
            myoptions = Console.ReadLine();

            switch (myoptions)
            {
                case "1":
                    AddStud();
                    break;
                case "2":
                    AddCRoom();
                    break;
                case "3":
                    AddStaff();
                    break;
                case "4":
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
            Console.WriteLine("==========================================");
            Console.WriteLine("ADD  A STUDENT");
            Console.WriteLine("==========================================");
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
            Console.WriteLine("==========================================");
            Console.WriteLine("Successfully Added!!!");
            Console.WriteLine("==========================================");

            for (int j = 0; j < n; j++)
            {
                
                Console.WriteLine("Student Name Added is: " + studName[j]);
                Console.WriteLine("Student Course Added is: " + studCourse[j]);
                
            }

            Console.ReadLine();

        }
        static void AddCRoom()
        {
            string[] studCR = new string[20];

            int n;
            Console.WriteLine("");
            Console.WriteLine("==========================================");
            Console.WriteLine("ADD  A CLASSROOM");
            Console.WriteLine("==========================================");
            
            Console.WriteLine("How many Classroom you wan to add? ");
            n = int.Parse(Console.ReadLine());

            for (int c = 0; c < n; c++)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Classroom Name");
                studCR[c] = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine("==========================================");
            Console.WriteLine("Succesfully Added!!!");
            Console.WriteLine("==========================================");


            for (int r = 0; r < n; r++)
            {
                
                Console.WriteLine("The Classroom Name is: " + studCR[r]);
                
            }

            Console.ReadLine();
        }
        static void AddStaff()
        {
            string[] staffName = new string[20];

            int n;
            Console.WriteLine("");
            Console.WriteLine("==========================================");
            Console.WriteLine("ADD A STAFF");
            Console.WriteLine("==========================================");

            Console.WriteLine("How many staff you want to add? ");
            n = int.Parse(Console.ReadLine());

            for (int s = 0; s < n; s++)
            {
                Console.WriteLine("Enter Staff Name.");
                staffName[s] = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine("==========================================");
            Console.WriteLine("Successfully Added!!!");
            Console.WriteLine("==========================================");

            for (int t = 0; t < n; t++)
            {
                
                Console.WriteLine("Staff Name added is: " + staffName[t]);
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
