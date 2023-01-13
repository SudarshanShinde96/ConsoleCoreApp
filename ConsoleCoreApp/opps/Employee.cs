using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.opps
{
    internal class Employee
    {
        int _EpmCode;
        string _EmpName;
        float _EmpSalary;


        //constrution
        public Employee()
        {
            Console.WriteLine("Default constructor called:");
            this._EmpSalary = 2000;
        }
        public Employee(int _EpmCode, string _EmpName, float _EmpSalary)
        {
            this._EpmCode = _EpmCode;
            this._EmpName = _EmpName;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Constructor with 3 argument");
        }
        public Employee(int _EpmCode, float _EmpSalary)
        {
             this._EpmCode= _EpmCode;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Constructor with 3 argument");
        }
        //static  constructors
        static Employee()
        {
            Console.WriteLine("Static constructor called");
        }
        ~Employee()//destructor
        {
            Console.WriteLine("distructor is called");
        }
        public void setEmployeeDetails(int _EpmCode , string _EmpName , float _EmpSalary)
        {
            this._EpmCode=_EpmCode;
            this._EmpName=_EmpName;
            this._EmpSalary= _EmpSalary;

            Console.WriteLine("detailes saved:");
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Detailes Are:");
            Console.WriteLine($"code:{_EpmCode}, Name:{_EmpName}, salary:{_EmpSalary}");
        }
    }
}
