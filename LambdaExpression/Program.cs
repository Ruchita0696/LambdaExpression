using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            AddRecords(listPersonsInCity);
            Retriving_Top_Two_Records_For_Age_LessThan_Sixty(listPersonsInCity);
            CheckingForTeenagerPersons(listPersonsInCity);
            Retrive_Average_Age(listPersonsInCity);

        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "jhon", "12 Main strret new york NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main ct new york NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elon", "14 Main strret new york NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main strret new york NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave Dayton OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 CranBrook road new york NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st new york NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave Baltimore NY", 85));

        }
        public static void Retriving_Top_Two_Records_For_Age_LessThan_Sixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => e.Age < 60).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge : " + person.Age);
            }
        }
        public static void CheckingForTeenagerPersons(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("YES, We have Some Teen-agers in the List");
            }
            else
            {
                Console.WriteLine("NO, We don't have Some Teen-agers in the List");

            }
        }
        public static void Retrive_Average_Age(List<Person> listPersonInCity)
        {
            Console.WriteLine("Average age is : " + listPersonInCity.Average(e => e.Age));

        }
    }
}
