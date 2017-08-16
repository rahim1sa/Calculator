using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int FirstNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int SecondNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Choose An Operation: (+; -; *; /;)");
            string Oper = Convert.ToString(Console.ReadLine());
            Calculator calc = new Calculator(FirstNum, SecondNum, Oper);
           
        }
    }
    
    class Calculator
    {
        public int Birinci;
        public int Ikinci;
        public int Netice;
        public string Oper;

        public  Calculator(int _birinci, int _ikinci, string _oper)
        {
            this.Birinci = _birinci;
            this.Ikinci = _ikinci;
            this.Oper = _oper;

            if (this.Oper == "+")
            {
                Console.WriteLine(this.Plus());
            }
            else if (this.Oper == "-")
            {
                Console.WriteLine(this.Netice); 
            }
            else if (this.Oper == "*")
            {
                this.Multiply();
            }
            else if (this.Oper == "/")
            {
                this.Divided();
            }
        }

        public int Plus()
        {
            this.Netice = this.Birinci + this.Ikinci;
            return this.Netice;
        }
        public int Minus()
        {
            this.Netice = this.Birinci - this.Ikinci;
            return this.Netice;
        }
        public int Multiply()
        {
            this.Netice = this.Birinci * this.Ikinci;
            return this.Netice;
        }
        public int Divided()
        {
            this.Netice = this.Birinci / this.Ikinci;
            return this.Netice;
        }


    }
}
