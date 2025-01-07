using System.Xml.Linq;
using Demo.Interface_Ex01;
using Demo.Interface_Ex02;
using Demo.Interface_Ex03;

namespace Demo
{
    // 1. class
    // 2. struct
    // 3. enum
    // 4. interface

    internal class Program
    {
        //static void Print10Number(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write(value: $"[series. Current)");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Number(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write(value: $"[series. Current)");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        static void Print10Number(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(value: $"[series. Current)");
                series.Next();
            }
            Console.WriteLine();
            series.Reset();
        }



        static void Print10Number(SeriesByFour series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(value: $"[series. Current)");
                series.Next();
            }
            Console.WriteLine();
            series.Reset();
        }
        static void Main()
        {
            #region Revision

            // Class Vs Struct
            //Inheritance:
            // X ---> Y
            // Relationships Between Classes
            // Ploymorphism

            #endregion

            #region Interfaces Ex01

            // Interfaces: Reference Type
            // Code Contract Between The Developer Who Write It And The Developer Who Use It (Implementation]

            // МуТуре пуТуре = new MyType();

            // NOTE: Can't Create Object From Any Interfaces

            //MyType myType = new MyType();
            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.MyFun();

            // ImyType myType1 = new IMyType();

            //myType1.MyFun();














            #endregion

            #region Interfaces Ex02

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();
            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10Number(seriesByTwo);

            //int[] Numbers = { 7, 6, 5, 4, 3, 2, 1, 8, 9 };

            //Array.Sort(Numbers);

            //foreach (int item in Numbers)
            //{
            //    Console.Write(value: $"{item}");
            //}

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee() { Id = 1, Name = "Ahmed", Age = 30, Salary = 12000 },
            //    new Employee() { Id = 2, Name = "Omar", Age = 27, Salary = 11000 },
            //    new Employee() { Id = 3, Name = "Amr", Age = 28, Salary = 13000 }
            //};

            //Array.Sort(employees);
            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Interfaces Ex03

            Car care = Car();

            


            #endregion















            }
    }
}
