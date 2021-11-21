using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;


namespace Labb_4___Collection_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------- Del 1 ---------------------------------------------------------

            ConsoleSettings(16,55);

            Employee E1 = new Employee { ID = 101, Name = "Viktor", Gender = "Male", Salary = 300000};
            Employee E2 = new Employee { ID = 102, Name = "Erik", Gender = "Male", Salary = 250000};
            Employee E3 = new Employee { ID = 103, Name = "Lucas", Gender = "Male", Salary = 270000};
            Employee E4 = new Employee { ID = 104, Name = "Anna", Gender = "Female", Salary = 310000};
            Employee E5 = new Employee { ID = 105, Name = "Tobias", Gender = "Male", Salary = 305000};


            Stack<Employee> StackOfEmployees = new Stack<Employee>();
            StackOfEmployees.Push(E1);
            StackOfEmployees.Push(E2);
            StackOfEmployees.Push(E3);
            StackOfEmployees.Push(E4);
            StackOfEmployees.Push(E5);


            titleAndPercentage("Trying to retriveing all items in the stack");
            foreach (Employee Employees in StackOfEmployees)
            {
                
                Console.WriteLine(Employees);
                Console.WriteLine("Items left in the stack: " + StackOfEmployees.Count);
            }
            pressToContinue();

            titleAndPercentage("Trying to retrive items using pop method");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(StackOfEmployees.Pop());
                Console.WriteLine("Items left in the stack: " + StackOfEmployees.Count);
            }


            StackOfEmployees.Push(E1);
            StackOfEmployees.Push(E2);
            StackOfEmployees.Push(E3);
            StackOfEmployees.Push(E4);
            StackOfEmployees.Push(E5);
            pressToContinue();


            titleAndPercentage("Trying to retrive items using peek method");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(StackOfEmployees.Peek());
                Console.WriteLine("Items left in the stack: " + StackOfEmployees.Count);
            }
            pressToContinue();

            titleAndPercentage("Trying to check if item number 3 is in the stack",1);
            if (StackOfEmployees.Contains(E3))
            {
                Console.WriteLine("Item number 3 was found in the stack!");
                Console.WriteLine(E3);
            }
            else
            {
                Console.WriteLine("Emp3 is not in the stack");
            }
            pressToContinue();

            //--------------------------------------------------- Del 2 ---------------------------------------------------------

            List<Employee> myList = new List<Employee>();

            myList.Add(E1);
            myList.Add(E2);
            myList.Add(E3);
            myList.Add(E4);
            myList.Add(E5);

            titleAndPercentage("Trying to check if Employee2 exist in the list",1);
            if (myList.Contains(E2))
            {
                Console.WriteLine("Employee2 object exist in the list!");
                Console.WriteLine(E2);
            }
            else
            {
                Console.WriteLine("Emplyee2 object does not exist in the list!",1);
            }
            pressToContinue();

            titleAndPercentage("Trying to find the first female in the list",1);
            Employee result = myList.Find(x => x.Gender == "Female");

            Console.WriteLine("First female in the list was found! \n"+ result);
            pressToContinue();

            titleAndPercentage("Trying to find all the males in your list");
            List<Employee> ListOfMales = new List<Employee>();
            ListOfMales = myList.FindAll(x => x.Gender == "Male");

            foreach (Employee Employees in ListOfMales)
            {
                Console.WriteLine(Employees);
            }
            End();

        }
        static void ConsoleSettings(int tempWindowHeight = 25, int tempWindowWidth = 70)
        {
            Console.WindowHeight = tempWindowHeight;
            Console.WindowWidth = tempWindowWidth;
        }// Konsol inställningar
        static void titleAndPercentage(string tempText = "",int tempSleepTime = 25)
        {

            MixedColor(tempText, 20);

            for (int i = 0; i <= 99; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(tempSleepTime);

            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\rProgress: 100%   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        } // Titel utskrift och en animation för Progress
        public static void MixedColor(string tempText = "", int temptextSpeed = 0)
        {

            string text = tempText;
            int textSpeed = temptextSpeed;

            for (int i = 0; i < text.Length; i++)
            {
                Random randomColor = new Random();

                Console.ForegroundColor = (ConsoleColor)randomColor.Next(6, 9);

                Thread.Sleep(textSpeed);
                Console.Write(text[i]);
            }
            Console.WriteLine();
        } // Skriver ut texten i olika färger (Hoppas det är lagom mycket färg denna gången)

        public static void pressToContinue()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            string bufferDots = "...";
            Console.Write("Press enter to continue");
            for (int i = 0; i < bufferDots.Length; i++)
            {
                Thread.Sleep(400);
                Console.Write(bufferDots[i]);

            }

            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);

            Console.Write("Press enter to continue");
            for (int i = 0; i < bufferDots.Length; i++)
            {
                Thread.Sleep(400);
                Console.Write(bufferDots[i]);

            }


            Console.ReadLine();
            Console.Clear();
        }// Tryck enter för att gå till nästa steg
        static void End()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("Press enter to close application");
            Console.ReadLine();
            Console.Clear();
        } // Avsluta



    }

}
