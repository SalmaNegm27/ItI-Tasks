namespace Lap4
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Runtime.Remoting.Channels;
    using System.Runtime.Remoting.Messaging;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;
    using static Lap4.Program;

    public class Program
    {

        //// class defines within namespace
        //#region Epmloyee class
        ////public class Employee
        ////{
        ////    // we can here gave fild intial value while struct cannot
        ////    private int id = 15;
        ////    private string name;
        ////    private int salary;

        ////    // default ctor we can explicit type it or not
        ////    // constructor chaining 
        ////    // remeber he goes inside the ctor at least
        ////    // we cab intolize all member fiels or not but in struct cannot 
        ////    public Employee() : this(1, "Test", 100)
        ////    {
        ////        Console.WriteLine("Hello from ctor 1");
        ////    }
        ////    public Employee(int _id) : this(_id, "Test", 100)
        ////    {
        ////        //id = 3;
        ////        Console.WriteLine("Hello from ctor 2!!!!!");
        ////    }
        ////    public Employee(int _id, string _name) : this(_id, _name, 100)
        ////    {

        ////    }
        ////    public Employee(int id, string name, int salary)
        ////    {
        ////        Console.WriteLine("Hello from ctor 3");
        ////        Salary = salary;
        ////        Name = name;
        ////        Id = id;
        ////    }

        ////    public int Salary
        ////    {
        ////        get { return salary; }
        ////        set { salary = value; }
        ////    }


        ////    public string Name
        ////    {
        ////        get { return name; }
        ////        set { name = value; }
        ////    }


        ////    public int Id
        ////    {
        ////        get { return id; }
        ////        set { id = value; }
        ////    }


        ////    // destractor didnt have acess modifier or paramerters and the GC(garbage collecter) implicity call it 
        ////    ~Employee()
        ////    {
        ////        Console.WriteLine("The object scope has ended");
        ////    }

        ////} 
        //#endregion
        //struct SStudent
        //{
        //    private int id;
        //    private string name;

        //    public string Name
        //    {
        //        get { return name; }
        //        set { name = value; }
        //    }

        //    public int ID
        //    {
        //        get { return id; }
        //        set { id = value; }
        //    }
        //    public void print()
        //    {
        //        Console.WriteLine($"Hello from struct student {ID} , {Name}");
        //    }

        //}
        //class CStudent
        //{
        //    private int id;
        //    private string name;

        //    public string Name
        //    {
        //        get { return name; }
        //        set { name = value; }
        //    }

        //    public int ID
        //    {
        //        get { return id; }
        //        set { id = value; }
        //    }
        //    public void print()
        //    {
        //        Console.WriteLine($"Hello from class student{ID},{Name}");
        //    }
        //}

        ////*******Inhertance***********
        //// refrence type only can ihnert
        //// clas can only inhert from one class but mulilevel supported in c#
        //#region DUMMY CLASS
        //class A
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //    public int Salary { get; set; }
        //    public void print()
        //    {
        //        Console.WriteLine("Hello from A");
        //    }
        //}
        //class B : A
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //    public int Salary { get; set; }
        //    public void print()
        //    {
        //        Console.WriteLine("Hello from B");
        //    }


        //}
        //class C : B
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //    public int Salary { get; set; }
        //    public void print()
        //    {
        //        Console.WriteLine("Hello from C");
        //    }

        //}
        //class D : C
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //    public int Salary { get; set; }
        //    public void print()
        //    {
        //        Console.WriteLine("Hello from D");
        //    }
        //}
        //#endregion
        //#region Inhertance
        ////class Employee
        ////{
        ////    private int id;
        ////    private string name;

        ////    public string Name
        ////    {
        ////        get { return name; }
        ////        set { name = value; }
        ////    }


        ////    public int ID
        ////    {
        ////        get { return id; }
        ////        set { id = value; }
        ////    }


        ////    public Employee(int _id, string _name)
        ////    {
        ////        id = _id;
        ////        name = _name;
        ////    }

        ////    public void print()
        ////    {
        ////        Console.WriteLine("Base Employee");
        ////    }
        ////}
        ////class FullTimeEmployee : Employee
        ////{

        ////    public int Salary { get; set; }
        ////    public int Bouns { get; set; }
        ////    public FullTimeEmployee(int salary, int bouns) : base(_id, _name)
        ////    {

        ////        Salary = salary;
        ////        Bouns = bouns;
        ////    }

        ////    public void Print()
        ////    {
        ////        Console.WriteLine("FullTimeEmployee");
        ////    }

        ////    public int CalcSalary()
        ////    {
        ////        return Salary + Bouns;
        ////    }

        ////}

        ////class PartTimeEmployee : Employee
        ////{

        ////    public int Deduction { get; set; }
        ////    public int Hours { get; set; }
        ////    public int HoursRate { get; set; }

        ////    public PartTimeEmployee(int deduction, int hours, int hoursRate)
        ////    {

        ////        Deduction = deduction;
        ////        Hours = hours;
        ////        HoursRate = hoursRate;
        ////    }

        ////    public void Print()
        ////    {
        ////        Console.WriteLine(" PartTimeEmployee");
        ////    }
        ////    public int CalacSlary()
        ////    {
        ////        return (Hours * HoursRate) - Deduction;
        ////    }
        ////}


        //#endregion
        //#region before abstract 
        ////public static void RunAllDraw(Shape[] arr)
        ////{

        ////}

        ////public static void CalculateAllAreas(Shape[] arr)
        ////{
        ////    for(int i=0; i<arr.Length; i++)
        ////    {
        ////        if (arr[i].GetType().Name == "Circle")
        ////        {

        ////            Console.WriteLine(((Circle)arr[i]).CalcArea()); 
        ////        }
        ////        else if (arr[i].GetType().Name == "Rectangle")
        ////        {

        ////            Console.WriteLine(((Rectangle)arr[i]).CalcArea());
        ////        }
        ////        else if (arr[i].GetType().Name == "Triangle")
        ////        {

        ////            Console.WriteLine(((Triangle)arr[i]).CalcArea()); 
        ////        }
        ////        else
        ////            Console.WriteLine(((Square)arr[i]).CalcArea());
        ////    } 
        ////}
        //#endregion


        public static float CalcAllAreas(Shape[] arr)
        {
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].CalcArea()); 
            }
            return sum;

        }

        public static string DrawAll(Shape[] arr)
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)

                str += arr[i].Draw()+"\n";

            return str;
        }

        static void Main(string[] args)

        {
            #region نص المحاضره الاول
            // refrence      object
            //Employee emp1 = new Employee();
            //Employee emp1;        //just a refrence cannot say emp1.Id just like int x; we have to intilize it
            //Employee emp2 = null;
            //emp2.Salary = 100;     //Run Time Error الrefrence ده يشاور علي فاضي فالهيب 
            //Console.WriteLine(emp1.Id);
            //Employee emp2 = new Employee(1);
            //Console.WriteLine(emp2.Id); //// the output is 3 be carefull......
            //emp1 == emp2
            // the same identity so the same state(values) but the oppisite doesnt true 
            #endregion

            #region Array of Strct vs Array of class
            // Array of Struct
            // refrence in heap and varible in heap because is struct(value type)
            //SStudent[] sStudents = new SStudent[2];
            //sStudents[0].ID = 1;
            //sStudents[0].Name= "test1";
            //sStudents[1].ID = 2;
            //sStudents[1].Name = "test2";
            //sStudents[0].print();
            //sStudents[1].print();
            //// Array of class
            //CStudent[] cStudent = new CStudent[2];
            // null refrence exception we need to inlize object firts
            //cStudent[0].print();
            //cStudent[1].print();
            // inlize object for array od refrence to student
            //cStudent[0]= new CStudent();
            //cStudent[1]= new CStudent();
            //Or
            //for(int i = 0; i<cStudent.Length; i++)
            //{
            //    cStudent[i]= new CStudent();
            //}
            //cStudent[0].ID = 1;
            //cStudent[0].Name = "test1";
            //cStudent[1].ID = 2;
            //cStudent[1].Name= "test2";
            //cStudent[0].print();
            //cStudent[1].print(); 
            #endregion

            #region Dummy Class
            //A a = new A();
            //a.print();
            //B b = new B();
            //b.print();
            //C c = new C();
            //c.print();
            //D d = new D();
            //d.print();
            //Console.WriteLine("Refrence from base refer to object from child");
            //A a2 = new B();
            //a2.print();
            //A a3 = new C();
            //a3.print();
            //A a4 = new D();
            //a4.print();
            //B b2 = new C();
            //b2.print();
            //B b3 = new D();
            //b3.print();
            //C c2 = new D();
            //((D)c2).print(); 
            #endregion

            #region inhertance
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(100, 50);
            //fullTimeEmployee.ID= 1;
            //Console.WriteLine(fullTimeEmployee.CalcSalary());
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee(50,2,50);
            //partTimeEmployee.ID = 1;
            //Console.WriteLine(partTimeEmployee.CalacSlary());
            //Employee emp = new FullTimeEmployee(100 , 10);
            //emp.print(); 
            #endregion

            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle(5);
            shapes[1] = new Rectangle(10, 20);
            shapes[2] = new Triangle(10, 10, 2);
            shapes[3] = new Square();
            //Console.WriteLine(shapes[0].CalcArea());
           CalcAllAreas(shapes);
            Console.WriteLine(DrawAll(shapes));

        }

    }
}