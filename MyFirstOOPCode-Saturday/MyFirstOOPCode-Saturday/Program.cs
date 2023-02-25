using System;
using System.Collections.Generic;

namespace MyFirstOOPCode_Saturday
{
    public class Program
    {
        public static List<string> OptionsMenu = new List<string>{ "1. Show employees.", "2. Add new employee.", "3. End program. \n" };
        static void Main(string[] args)
        {
            int  OptionSelected = 0;
            List<SalaryEmployee> Employees = new List<SalaryEmployee>();
            do {
                Utils.Show(OptionsMenu);
                OptionSelected = Utils.GetValueTypeInt("option");

                switch (OptionSelected)
                {
                    case 1:
                        Utils.Show(Employees);
                        break;
                    case 2:
                        Employees.Add(new SalaryEmployee()
                        {
                            Id = Employees.Count + 1,
                            FirstName = Utils.GetValueTypeString("firstName"),
                            LastName = Utils.GetValueTypeString("lastName"),
                            BirthDate = new Date(Utils.GetValueTypeInt("Year of birthDate"), Utils.GetValueTypeInt("month of birthDate"), Utils.GetValueTypeInt("day of birthDate")),
                            HiringDate = new Date(Utils.GetValueTypeInt("Year of Hiring"), Utils.GetValueTypeInt("month of Hiring"), Utils.GetValueTypeInt("day of Hiring")),
                            IsActive = Utils.GetValueTypeBoolean("is Active"),
                            Salary = Utils.GetValueTypeDecimal("Salary")
                        });
                        Console.WriteLine("Successful registration");
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("The option selected is not defined");
                        break;
                }
            } while (OptionSelected != 3);
        }

    }
}
