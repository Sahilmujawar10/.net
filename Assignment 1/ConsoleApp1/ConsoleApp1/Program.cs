using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("rushikesh", 20000, 1);
            e1.Display();
            Console.WriteLine();

            Employee e2 = new Employee("rohit", 25000);
            e2.Display();
            Console.WriteLine();

            Employee e3 = new Employee("rahul", 102);
            e3.Display();
            Console.WriteLine();

            Employee e4 = new Employee("ravi");
            e4.Display();
            Console.WriteLine();

            Employee e5 = new Employee();
            e5.Display();
            Console.WriteLine();

            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e3.EmpNo);
            Console.WriteLine(e4.EmpNo);
            Console.WriteLine(e5.EmpNo);
            Console.WriteLine(e5.EmpNo);
            Console.WriteLine(e4.EmpNo);
            Console.WriteLine(e3.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e1.EmpNo);

            Console.ReadLine();
        }
    }

    public class Employee
    {
        private string name;
        private int empNo = count;
        private decimal basic;
        private short deptNo;
        public static int count = 1;
        public string Name
        {
            set
            {
                if (!(value == ""))
                {
                    name = value;
                }
                else
                    Console.WriteLine("Blank Space Not Allowed ");
            }
            get
            {
                return name;
            }

        }
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        public decimal Basic
        {
            set
            {
                if (value > 10000 && value < 30000)
                    basic = value;
                else
                    Console.WriteLine("Basic must be within range");
            }
            get
            {
                return basic;
            }
        }
        public short Deptno
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                    Console.WriteLine("DeptNo must be greter than zero");
            }
            get
            {
                return deptNo;
            }
        }

        public Employee(string Name = "", decimal Basic = 0, short Deptno = 1)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.Deptno = Deptno;
            count++;
        }

        public void CalSalary()
        {
            int hra = (int)((int)Basic * 0.4);
            Console.WriteLine("NetSalary: " + (Basic + hra));
        }

        public void Display()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("empNo : " + empNo);
            Console.WriteLine("basic : " + basic);
            CalSalary();
            Console.WriteLine("deptNo: " + deptNo);

        }

    }
}