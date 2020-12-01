using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee("Amol", 123465, 10);
            //Employee e2 = new Employee("Amol", 123465);
            //Employee e3 = new Employee("Amol");
            //Employee e4 = new Employee();
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();

            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e3.EmpNo);


            Console.WriteLine(e3.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e1.EmpNo);
            // Console.WriteLine(e4.EmpNo);
            Console.ReadLine();
        }
    }
    public class Employee
    {
        string Name;
        static int E = 0;
        int Emp_no;
        decimal Basic;
        short Dept_No;
        double Salary;
        public Employee()
        {
            E = E + 1;
            Emp_no = E;
        }
        public Employee(string s)
        {
            E = E + 1;
            Emp_no = E;
            Name = s;
        }
        public Employee(string s ,decimal b)
        {
            E = E + 1;
            Emp_no = E;
            Name = s;
            Basic = b;
        }
        public Employee(string s,decimal b,short d)
        {
            E = E + 1;
            Emp_no = E;
            Name = s;
            Basic = b;
            Dept_No = d;

        }
        public String Name1
        {
            set
            {
                if (value == "")
                    Console.WriteLine("Invalid Name");
                else
                    Name = value;
            }
            get
            {
                return Name;
            }
        }
        public int EmpNo
        {
            get
            {
                return Emp_no;
            }
        }
        public short DeptNo1
        {
            set
            {
                if(value > 0)
                    Dept_No = value;
                else
                    Console.WriteLine("Invalid Department No");
            }
        }
        public double Salary1
        {
            set
            {
                if (Basic > 12000)
                    Salary = (double)Basic * 2;
                else
                    Salary = (double)Basic * 1.5;

            }
            get
            {
                return Salary;
            }
        }
    }
}
