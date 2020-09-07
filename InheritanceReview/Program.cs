using System;
using System.Collections.Generic;

namespace LearningCollections
{
    class Program
    {
        static void Main(string[] args)

        {

            //instantiate a new Student Class object
            var students = new List<Student>();
            //to access the Name property, specify the object variable name
            //use the dot operator after specifying the object variable name
            //to access the Name property


            //boolean that means in this while loop, all code will
            //continue to happen in it until reaching a false condition
            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                //refactored code
                //Util is the namespace and AskAQuestion the class that holds
                //the Ask method
                newStudent.Name = Util.AskAQuestion.Ask("Student Name...");

                //Console.Write("Student Grade...");
                newStudent.Grade = (int.Parse(Util.AskAQuestion.Ask("Student Grade...")));

                //Console.Write("Student Birthday...");
                newStudent.Birthday = (Util.AskAQuestion.Ask("Student Birthday..."));

                //Console.Write("Student Address...");
                newStudent.Address = (Util.AskAQuestion.Ask("Student Address..."));

                //data type for phone# (and grade) in Class property is int
                //Console.Write("Student Phone...");
                //phone number is set and kept private through 'private' access
                //specifier and public void method 'SetPhone'

                //newStudent.SetPhone(int.Parse(Console.ReadLine()));
                //using Phone setter
                newStudent.Phone = (int.Parse(Util.AskAQuestion.Ask("Student Phone...")));


                //add a newStudent to the List <Student> collection
                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count is: {0}", Student.Count);

                Console.Write("Add another student? y/n");

                if (Console.ReadLine() != "y")
                {
                    //break out of while loop because we flip the
                    //boolean and adding arg to false once "y" typed
                    adding = false;
                }

                foreach (var student in students)
                {
                    //Name is obj arg 0 as string(student.Name), and Grade is obj arg 1 as int(student.Grade)
                    //parameters arr[i] lists the data from the loop
                    Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                    //workin with namespaces tomorrow;util classes
                }
            }
        }

    }

    class Member
    {
        //Member class will have properties that both Student
        //and Teacher share to avoid duplicate code
        public string Name;
        public string Address;
        //'protected' accessors allows other classes to inherit
        //properties from a class
        //works like 'private', but it works with inheritance where
        //private does not; private allows access only within class
        protected int Phone;
    }

    class Student : Member
    {
        //Count will be independent of instantiated Student
        //Count will not rely on each specific Student
        public static int Count;

        public int Grade;
        public string Birthday;
        //encapsulation
        //accessability of specifier
        //common practice to use first letter of variable name 
        //lower case to indicate 'private'

        public Student()
        {
            //an empty constructor in this situation allows user
            //or teacher for the student's information AFTER we 
            //create the student
        }


        //Constructor should be named the same as the class
        //i.e. Student Class
        //now that our constructor requires parameters, we can't just create a new student
        //and pass in nothing
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            //pass all data upfront when creating a Student
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
            //The constructor executes as soon as the object
            //is created or constructed i.e line 23S
            //Console.Write("constructor");
        }

        private int phone;

        public void SetPhone(int number)
        {
            phone = number;
        }
        //C# property
        //instead of passing paramter through method
        //setter can be used to declare value of phone
        public int Phone
        {
            //use a standard '=' to assign the phone number
            //like we would for a variable
            set { phone = value; Console.WriteLine(phone); }
        }

    }

    class Teacher
    {

    }
}