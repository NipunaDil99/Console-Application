using System;

namespace File2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("-----------Employee---------");
            Console.Write("Press 'y' if you want to create an user otherwise 'n':");
            char a = Convert.ToChar(Console.ReadLine());
            if(a == 'y')
            {
                Employee employee = new Employee();
                Console.Write("Enter First name of the Employee :");
                employee.fname = Console.ReadLine();
                Console.Write("Enter Second name of the Employee :");
                employee.lname = Console.ReadLine();
                Console.Write("Enter Age of the Employee :");
                employee.age = Convert.ToInt32(Console.ReadLine());


                for(int i = 0; i < employee.fname.Length; i++)
                {
                    if((employee.fname[i] >= 'A' && employee.fname[i] <= 'Z') || (employee.fname[i] >= 'a' && employee.fname[i] <= 'z'))
                    {
                        count++;
                    }
                }

                Console.WriteLine("\n");


                if(count == employee.fname.Length)
                {
                    Console.WriteLine("Entered First name is valid");
                }
                else
                {
                    Console.WriteLine("First Name should be only contain alphabatical characters");
                }


                count = 0;


                for (int i = 0; i < employee.lname.Length; i++)
                {
                    if ((employee.lname[i] >= 'A' && employee.lname[i] <= 'Z') || (employee.lname[i] >= 'a' && employee.lname[i] <= 'z'))
                    {
                        count++;
                    }
                }


                if (count == employee.lname.Length)
                {
                    Console.WriteLine("Entered Last name is valid");
                }
                else
                {
                    Console.WriteLine("Last Name should be only contain alphabatical characters");
                }


                if(employee.age >= 20 && employee.age <= 65)
                {
                    Console.WriteLine("Entered age is valid");
                }
                else
                {
                    Console.WriteLine("Entered age is invalid");
                }

                Console.WriteLine("\n");

                Console.WriteLine("First Name of the employee :"+employee.fname);
                Console.WriteLine("Lasst Name of the employee :" + employee.lname);
                Console.WriteLine("Age of the employee :" + employee.age);

                Console.WriteLine("\n\n\n");
                Console.WriteLine("---------Department--------");

                Console.Write("Press 'y' if you want to choose a Department otherwise 'n':");
                char b = Convert.ToChar(Console.ReadLine());
                if (b == 'y')
                {
                    Department department = new Department();
                    Console.Write("Enter the name of the Department :");
                    department.name = Console.ReadLine();

                    Console.WriteLine("Employee '"+employee.fname+" "+employee.lname+"' is assigned to "+department.name+" department");
                    return;
                }
                else if (b == 'n')
                {
                    Console.WriteLine("------------Exit-------------");
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    return;
                }

            }
            else if(a == 'n')
            {
                Console.WriteLine("------------Exit-------------");
                return;
            }
            else
            {
                Console.WriteLine("Wrong input");
                return;
            }
            
        }
    }
    class Employee
    {
        public string fname;
        public string lname;
        public int age;
    }

    class Department
    {
        public string name;
    }
}
