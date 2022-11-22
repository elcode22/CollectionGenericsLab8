using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {           
             Employee e1 = new Employee() { ID = 1, Name = "Alan",  Gender = "man", Salary = 23000 };
             Employee e2 = new Employee() { ID = 2, Name = "karin", Gender = "kvinna", Salary = 23000 };
             Employee e3 = new Employee() { ID = 3, Name = "Tony", Gender = "man", Salary = 23000 };
             Employee e4 = new Employee() { ID = 4, Name = "Oskar", Gender = "man", Salary = 23000 };
             Employee e5 = new Employee() { ID = 5, Name = "Anna", Gender = "kvinna", Salary = 23000 };

            // Skriver ut alla anställda i stacken stackEmp
            Stack<Employee> stackEmp = new Stack<Employee>();

            stackEmp.Push(e1);
            stackEmp.Push(e2);
            stackEmp.Push(e3);
            stackEmp.Push(e4);
            stackEmp.Push(e5);

            foreach (var emp in stackEmp)
            {
                Console.WriteLine("Items in the stack: " + stackEmp.Count);
                Console.WriteLine($"Id: {emp.ID} namn: {emp.Name} Gender:{emp.Gender} lön: {emp.Salary}");
            }
            // Nu kommer pop metod
            Console.WriteLine("******************************");

            Console.WriteLine($"Id: {e1.ID} namn: {e1.Name} Gender:{e1.Gender} lön: {e1.Salary}");
            stackEmp.Pop();
            Console.WriteLine("Items in the stack = " + stackEmp.Count);
            stackEmp.Pop();
            Console.WriteLine("Items in the stack = " + stackEmp.Count);
            stackEmp.Clear();
            Console.WriteLine("Items in the stack = " + stackEmp.Count);
            if (stackEmp.Contains(e2))
            {
                Console.WriteLine("e2 finns i stacken");
            }
            else 
            {
                Console.WriteLine("e2 finns inte i stacken");
            }
            Console.WriteLine("******************************");
            // Kikar och kollar vilken anställd som ligger högst upp i stacken stackEmp 
            stackEmp.Push(e1);
            stackEmp.Push(e2);
            stackEmp.Push(e3);
            stackEmp.Push(e4);
            stackEmp.Push(e5);

            Employee peek = stackEmp.Peek();
            Console.WriteLine($"ID: {peek.ID}, Name: {peek.Name}, Gender: {peek.Gender}, Salary: {peek.Salary}");

            Console.WriteLine("******************************");


            // Arbetar med listan
            List<Employee> listEmp = new List<Employee>();

            listEmp.Add(e1);
            listEmp.Add(e2);
            listEmp.Add(e3);
            listEmp.Add(e4);
            listEmp.Add(e5);

            // Kolla om listan har e2
            if (listEmp.Contains(e2))
            {
                Console.WriteLine("e2 object exists in the list");
            }
            else
            {
                Console.WriteLine("e2 object does not exist in the list");
            }


            // Hitta första man i listan(find) svaret måste komma i en instans av employee
            Employee foundEmp = listEmp.Find(gen => gen.Gender == "man");
            Console.WriteLine($"ID: {foundEmp.ID}, Name: {foundEmp.Name}, Gender: {foundEmp.Gender}, Salary: {foundEmp.Salary}" + "\n");


            // Hitta män i listan(findAll) svaret måste komma i en lista
            foreach (Employee emp in listEmp.FindAll(gen => gen.Gender == "man")) 
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
            }

        }
    }
}
