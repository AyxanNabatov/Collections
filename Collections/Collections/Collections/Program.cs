using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>();

            //nums.Add(5);
            //nums.Add(55);
            //nums.Add(53);
            //nums.Add(9);

            //List<string> words = new list<string>();
            //words.Add("ahgsesdf");
            //words.Add("sibs");
            //words.Add("olgvni");
            //words.Add("einviet");

            //foreach(var item in words)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(nums[0]);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i=0; i<nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("Lis count is[0]", nums.Count);
            //}

            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("Lis count is[0], elave reqem{ 1}", nums.Count, 15);
            //}

            List<Person> people = new List<Person>();
            //Person person1 = new Person();
            //person1.Name = "Oan";

            //people.Add(person1);

            Person person2 = new Person
            {
                Id = 6,
                Name = "Ramil",
                Email = "ramil@gmail.com",
            };

            people.Add(person2);



            people.Add(new Person { Id = 1, Name = "Orxan", Email = "orxan@gmail.com" });
            people.Add(new Person { Id = 2, Name = "Oran", Email = "oran@gmail.com" });
            people.Add(new Person { Id = 3, Name = "Orxn", Email = "orxn@gmail.com" });
            people.Add(new Person { Id = 1, Name = "Oxan", Email = "oxan@gmail.com" });


            //Console.WriteLine(person2.Name);
            GetStudents(people);
        }

        public static void GetStudents(List<Person> students)
        {
            foreach (var stu in students)
            {
                Console.WriteLine("Students : Id - {0}, Name - {1}, Email - {2}", stu.Id, stu.Name, stu.Email);
            }
        }

        public static void GetNumbers(List<Person> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

}
