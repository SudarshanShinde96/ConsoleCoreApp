using ConsoleCoreApp.Day4;
using ConsoleCoreApp.Day4.Assignment2;
using ConsoleCoreApp.opps;
using Microsoft.VisualBasic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x=30;

Console.WriteLine($"integer is {x}");

Test.Main();


/*
//Read key
Console.WriteLine("Press Any key");
//ConsoleKeyInfo ck=Console.ReadKey();
ConsoleKeyInfo ck = Console.ReadKey(true);
Console.WriteLine("*");

//ck.Key =>ConsoleKey
//ck.key=>char

Console.WriteLine($"Pressed key :{ck.Key}");
Console.WriteLine($"pressed key keyword:{ck.KeyChar}");*/

/*
string password = "";
ConsoleKeyInfo ck = Console.ReadKey(true);

for (int i = 0; ; i++)
{    
    Console.Write("*");
    password += ck.KeyChar;
    ck = Console.ReadKey(true); 
    if (ck.Key==ConsoleKey.Enter)
    {
        break;
    }
}
Console.WriteLine($"\n{ password}");

*/



//using foreach
int[] arr =new int[5] {1,2,3,4,5};

Console.WriteLine("Array Elements Are:");

//forwardonly
//readonly
//foreach(Type identifier in Collection / array) { }

foreach (int item in arr)
{
    Console.WriteLine(item);
}



//boxing 
int num = 30;
object obj = num;
Console.WriteLine(obj);
//unboxing
int y = (int)obj;
Console.WriteLine(y);

//object,var,dynamic
var v = num;
int a = v;
Console.WriteLine(a);
Console.WriteLine(v);

dynamic dvar = num;
int b=dvar;
Console.WriteLine(b);
Console.WriteLine(dvar);

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine("Array Elements Are:");
foreach (var item in arr)
{
    Console.WriteLine(item);
}

/*
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
12 jan 2023  opps consepts
 */
//object creation
Employee employee = new Employee();

employee.DisplayEmployeeDetails(); //0,null,0
employee.setEmployeeDetails(1000, "Ratish", 250000f);
employee.DisplayEmployeeDetails();  //1000,ratish,250000


Employee employee2 = employee;

employee2.DisplayEmployeeDetails();
employee2.setEmployeeDetails(1001, "rohit", 26000.0f);

employee.DisplayEmployeeDetails();
employee2.DisplayEmployeeDetails();

var emp3 = new Employee();
emp3.DisplayEmployeeDetails();

dynamic emp4 = new Employee();
emp4.DisplayEmployeeDetails();

Employee emp5 = new();
emp5.DisplayEmployeeDetails();

//
MethodCalling obj1 = new MethodCalling();
int num1 = 30;
int num2 = 20,sum,sub;
Console.WriteLine($"num1:{num1} num2:{num2}");

//call by value
obj1.CallByValue(num1, num2);//50,50
Console.WriteLine($"num1:{num1} num2:{num2}");//30,20

//call by refrence using ref keyword
//obj1.CallByRef(ref num1,ref num2);
//Console.WriteLine($"num1:{num1} num2:{num2}");//50,20

//call by reference using out keyword 
obj1.CallByout(num1,num2,out sum,out sub);
Console.WriteLine($"sumation:{sum} substrtion:{sub}");//50,-10

//call by  named optional
obj1.CallByNamedOptional(id: 23, salary: 12345, sname: "shine", fname: "sun");//call by name doesnt require sequince
obj1.CallByNamedOptional(id: 23,sname: "shine",fname: "sun");//one parameter here is optional




/*
 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
13 jan 2023
 */
//constructors
Employee emp11 = new Employee();
Employee emp21 = new();

Employee emp31 = new(101, "Ratish", 10000);
Employee emp41 = new(102, "rohit", 10000);
Employee emp51 = new(103,3500);


emp11.DisplayEmployeeDetails();
emp21.DisplayEmployeeDetails();
emp31.DisplayEmployeeDetails();
emp41.DisplayEmployeeDetails();
emp51.DisplayEmployeeDetails();

GC.Collect(0);

//using point class
Point p1 = new Point(20,30);
Point p2 = new Point(30,20);

Point p3 = p1 + p2;
Point p4 = p1 - p2;

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
Console.WriteLine(p4);

if (p1 == p2)
{
    Console.WriteLine("Both Are Same");
}
else
{
    Console.WriteLine("Both are different");
}


//using staticclass

//StaticClass s1 = new StaticClass();
//StaticClass s2 = new StaticClass();
//StaticClass s3 = new StaticClass();

//s3.displayID();
//s2.displayCount(); //invalid

StaticClass.displayCount();
//s1.displayID();

Singleton obj4 = Singleton.getObject();

obj4.msg();