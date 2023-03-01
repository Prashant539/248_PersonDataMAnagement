using System;
namespace PersonDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { SSN = 1, Name = "Prahant", Address = "Lucknow", Age = 17 });
            people.Add(new Person() { SSN = 2, Name = "Vijay", Address = "Kanpur", Age = 14 });
            people.Add(new Person() { SSN = 3, Name = "Kapil", Address = "Gorakhpur", Age = 52 });
            people.Add(new Person() { SSN = 4, Name = "Ram", Address = "Basti", Age = 5 });
            people.Add(new Person() { SSN = 5, Name = "Aakash", Address = "Delhi", Age = 10 });
            people.Add(new Person() { SSN = 6, Name = "Rupesh", Address = "Pune", Age = 65 });
            people.Add(new Person() { SSN = 7, Name = "Akhil", Address = "Noida", Age = 70 });
            people.Add(new Person() { SSN = 8, Name = "Aditya", Address = "Panjab", Age = 85 });
            people.Add(new Person() { SSN = 9, Name = "Vishnu", Address = "Kerla", Age = 7 });
            people.Add(new Person() { SSN = 10, Name = "Anil", Address = "Asam", Age = 55 });
        }
    }
}
