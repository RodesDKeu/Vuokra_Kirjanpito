using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;



namespace testing
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("main method");
        }

        #region Delegate passthrou
        public class Testt
        {
            //Declare a delegate
            public delegate int CalculateDelegate(int x, int y);

            //method Add & Multiply
            //wich are going to be used throu the delegate
            public int Add(int x, int y) { return x + y; }
            public int Multiply(int x, int y) { return x * y; }

            public Testt(int a, int b)
            {
                //initiate delegate
                CalculateDelegate cal = Add;
                //call the Add method throu the delegate
                Console.WriteLine(cal(a, b));
            }

        #endregion



            #region  MulticastDelegate Method
            public class MultiCastDelegate
            {
                /// <summary>
                /// MethdOne
                /// </summary>
                public void MethodOne()
                {
                    Console.WriteLine("MethodOne");
                }

                /// <summary>
                /// MethodTwo
                /// </summary>
                public void MethodTwo()
                {
                    Console.WriteLine("MethodTwo");
                }

                /// <summary>
                /// Delegate to use to combine Methods
                /// </summary>
                public delegate void Del();

                /// <summary>
                /// MultiCastDelegate. Combines MethodOne and MethodTwo
                /// </summary>
                public MultiCastDelegate()
                {

                    Del d = MethodOne;
                    d += MethodTwo;
                    d();


                }
            }
            #endregion

            
        }
    }
}
