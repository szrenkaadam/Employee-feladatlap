using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_feladatlap
{
    class Alkalmazott
    {
        //name, age, city, department, position, gender, marital status, salary
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string Marital { get; set; }
        public int Salary { get; set; }

        public Alkalmazott(string sor)
        {
            string[] valami = sor.Split(';');


            Name = valami[0];
            Age = Convert.ToInt32(valami[1]);
            City = valami[2];
            Department = valami[3];
            Position = valami[4];
            Gender = valami[5];
            Marital = valami[6];
            Salary = Convert.ToInt32(valami[7]);

        }
        public void kiir()
        {
            Console.WriteLine($"{Name,-8}/ {Age,3}/ {City,10}/ {Department,8}/ {Position,8}/ {Gender,5}/ {Marital,7}/ {Salary, 7} ");
        }


    }
}
