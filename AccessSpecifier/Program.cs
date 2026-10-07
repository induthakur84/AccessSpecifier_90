

///What is the Access Specifier in C#?
///
// Access Specifier in C# are  the keywords used to define the accessiblity.
//of our classes, methods , properties, and other member.



// the main access specifier in C# are:

//1. public :Members declared as public can be access from anywhere inside the code


//2.Private: Members declared as private can be only be accessed within the same class.

//3. Protected: Members declared as protected can be accessed with the same class

// and the by derived classs.
// 4 Internal : Members declared as internal can be accessed with the same assemble,
// but not from the other assembles

// Protected internal: members declared as protected internal can be accessed
// with the same aseemley project or from a derived class, even if the derived class 

// from the another assemnbly.


using System.Xml.Linq;

///What is the Access Specifier in C#?
///
namespace AccessSpecifier
{

    class Student
    {
        public string Name = " Admin"; // public variable


        //private variable 


        private int age=20;// private variable



        //protect variable(same class and derived class)


        protected string College = "Abc";


        internal string City = "xyz";


        public void ShowStudentDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("College: " + College);
            Console.WriteLine("City: " + City);
        }

    }



    class CollegeStudent: Student
    {
        public void ShowCollegeDetails()
        {
            Console.WriteLine("Name: " + Name);
          //  Console.WriteLine("Age: " + age);
            Console.WriteLine("College: " + College);
            Console.WriteLine("City: " + City);

        }
    }

    class otherClass
    {
        public void ShowOtherDetails()
        {
            Student s= new Student();
            Console.WriteLine("Name: " + s.Name);
            //Console.WriteLine("Age: " + s.age);
            //Console.WriteLine("College: " + s.College);
            Console.WriteLine("City: " + s.City);

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ShowStudentDetails();


            CollegeStudent collegeStudent = new CollegeStudent();
            collegeStudent.ShowStudentDetails();

            otherClass otherClass = new otherClass();
            otherClass.ShowOtherDetails();
        }
    }
}