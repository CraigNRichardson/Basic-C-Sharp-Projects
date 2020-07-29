using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsList_203
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> lstEmp = new List<Employee>();
            lstEmp.Add(new Employee());
            lstEmp[0].EmpID = 1;
            lstEmp[0].EmpName = "Joe Garcia";
            lstEmp.Add(new Employee());
            lstEmp[1].EmpID = 2;
            lstEmp[1].EmpName = "Joe Walsh";
            lstEmp.Add(new Employee());
            lstEmp[2].EmpID = 3;
            lstEmp[2].EmpName = "Ada Lovelace";
            lstEmp.Add(new Employee());
            lstEmp[3].EmpID = 4;
            lstEmp[3].EmpName = "Joel Robbins";
            lstEmp.Add(new Employee());
            lstEmp[4].EmpID = 5;
            lstEmp[4].EmpName = "Grace Turner";
            lstEmp.Add(new Employee());
            lstEmp[5].EmpID = 6;
            lstEmp[5].EmpName = "Joey Rasmussen";
            lstEmp.Add(new Employee());
            lstEmp[6].EmpID = 7;
            lstEmp[6].EmpName = "Joely Porchent";
            lstEmp.Add(new Employee());
            lstEmp[7].EmpID = 8;
            lstEmp[7].EmpName = "Joanne Carruthers";
            lstEmp.Add(new Employee());
            lstEmp[8].EmpID = 9;
            lstEmp[8].EmpName = "Bill Sanford";
            lstEmp.Add(new Employee());
            lstEmp[9].EmpID = 10;
            lstEmp[9].EmpName = "Christopher Shrubbins";






            //foreach method:
            foreach (Employee emp in lstEmp)
            {
                if (emp.EmpName.StartsWith("Joe "))

                    Console.WriteLine(emp.EmpName);
            }
            Console.ReadLine();


            //Lambda Method:
            List<Employee> newList = lstEmp.Where(x => x.EmpName.StartsWith("Joe ")).ToList();
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.EmpName);
            }
            Console.ReadLine();

            //Lambda Employees with ID's > 5:
            List<Employee> idList = lstEmp.Where(x => x.EmpID > 5).ToList();
            foreach (Employee employee in idList)
            {
                Console.WriteLine("ID: " + employee.EmpID + "\t" + " Name: " + employee.EmpName);
            }
            Console.ReadLine();




        }
    }
}
