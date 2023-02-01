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
            Console.WriteLine(listPersonInCity.ToString());
           
        }
    }
}