using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex01
{
    internal class MyType : IMyType /*: -> Implement*/
    {
        //public double Salary
        //{
        //    get
        //    { throw new NotImplementedException(); }
        //    set
        //    { throw new NotImplementedException(); }
        //}

        //public void MyFun()
        //{
        //    throw new NotImplementedException();
        //}

        public double Salary { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public void MyFun()
        {
            Console.WriteLine(value: "Hallo World :)");
        }



    }
}
