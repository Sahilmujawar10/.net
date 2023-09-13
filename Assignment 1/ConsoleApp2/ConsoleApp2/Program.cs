using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1
{
    class Program
    {
        static void Main(string[] args)
        {



            Employee em = new Employee();
            Console.WriteLine("With wrong value");
            em.Empno = -10;
            em.Name = "";
            em.Salary = 1000;
            em.Deptno = -5;
            Console.WriteLine("Gross salary is: " + em.grsssalary());
            //Console.WriteLine(em.Empno);
            //Console.WriteLine(em.Name);
            //Console.WriteLine(em.Salary);
            //Console.WriteLine(em.Deptno);


            Console.WriteLine("--------*---------");

            Console.WriteLine("With right value");


            Employee em1 = new Employee();
            em1.Empno = 10;
            em1.Name = "Rohitt";
            em1.Salary = 25000;
            em1.Deptno = 5;
            em1.grsssalary();
            Console.WriteLine("Gross salary is: " + em1.grsssalary());
            //Console.WriteLine(em1.Empno);
            //Console.WriteLine(em1.Name);
            //Console.WriteLine(em1.Salary);
            //Console.WriteLine(em1.Deptno);



        }
    }

    class Employee
    {
        private string name;
        private int empno;
        private double salary;
        private int deptno;
        //private double grosssalary;
        public int Empno
        {
            get
            {
                return empno;
            }
            set
            {
                if (value > 0)
                {
                    empno = value;
                    Console.WriteLine("Employee no is: " + value);
                }
                else
                {
                    Console.WriteLine("Enter greater than 0");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if ((!(value.Length > 0)) && (!(value.Contains(" "))))
                {
                    Console.WriteLine("Employee name should not conatain Space or Employee name should not blank");
                }
                else
                {
                    name = value;
                    Console.WriteLine("Employee name is: " + value);
                }
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if ((value > 10000) && (value < 50000))
                {
                    salary = value;
                    Console.WriteLine("Employee salary is: " + value);
                }
                else
                {
                    Console.WriteLine("Salary must be in range 10000 and 50000");
                }
            }
        }

        public int Deptno
        {
            get
            {
                return deptno;
            }
            set
            {
                if (value > 0)
                {
                    deptno = value;
                    Console.WriteLine("Employee Department is: " + value);
                }
                else
                {
                    Console.WriteLine("Enter Department greater than 0");
                }
            }
        }


        public double grsssalary()
        {
            return ((salary * 0.4) + salary);
        }



    }

}

