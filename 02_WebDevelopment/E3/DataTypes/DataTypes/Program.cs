using System;
using System.Collections.Generic;

namespace DataTypes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string text = "This is a string";
			int age = 19;
			DateTime now = DateTime.Now;
			double amount = 0;

			string string2 = text + " a second string " + now;

			string string3 = string.Format("The age is {0}, the time is {1}, and the amount is {2}", age, now, amount);

			String string4 = $"The age is {age}, the time is {now}, and the amount is {amount}";

			char sampleChar = 'C';
			char[] arrayChar = string4.ToCharArray();

			for (int i = 0; i < arrayChar.Length; i++)
			{
				Console.WriteLine(string4[i]);
			}

			amount = (double)10 / (double)3;

			DateTime dateTime = new DateTime(2000, 1, 1);
			var timeStamp = now - dateTime;


			

			string test = "15";

			string booleanValue = "true";
			bool isTrue = bool.Parse(booleanValue);
			age = int.Parse(test);


            //Exercise 3 dataTypes

            List<Customer> customers = new List<Customer>();

			customers.Add(new Customer(1, "Juan Barrera", new DateTime(2019,1,12)));
            customers.Add(new Customer(2, "Jonatan Barcenas", new DateTime(2022, 8, 30)));
            customers.Add(new Customer(3, "Diana Acosta", new DateTime(2023, 1, 2)));
            customers.Add(new Customer(4, "Alfonso Acosta", new DateTime(2019, 8, 12)));
            customers.Add(new Customer(5, "Bryan Reyes", new DateTime(2003, 7, 22)));
            customers.Add(new Customer(6, "Catalina Velazquez", new DateTime(2023, 5, 5)));
            customers.Add(new Customer(7, "Steven Barcenas", new DateTime(2003, 4, 28)));
            customers.Add(new Customer(8, "Cristian Barcenas", new DateTime(2019, 1, 12)));
            customers.Add(new Customer(9, "Asley Archundia", DateTime.Now));
            customers.Add(new Customer(10, "Mariana Martinez", new DateTime(2021, 1, 15)));

			Console.WriteLine("Using the foreach loop");

			foreach (Customer customer in customers)
			{
				Console.WriteLine($"\n Costumer name: {customer.Name} \n Date of registration: {customer.Date}");
			}

            Console.WriteLine("\n Using the for loop");

			for (int i = 0;i != customers.Count; i++)
			{
                Console.WriteLine($"\n Costumer name: {customers[i].Name} \n Date of registration: {customers[i].Date}");
            }

            Console.WriteLine("\n Using the while loop");

			int Count = 0;
			while (Count!=customers.Count)
			{
                Console.WriteLine($"\n Costumer name: {customers[Count].Name} \n Date of registration: {customers[Count].Date}");
				Count++;
            }

            Console.WriteLine("\n Using the do-while loop");


			int Count2 = 0;
			do {
                Console.WriteLine($"\n Costumer name: {customers[Count2].Name} \n Date of registration: {customers[Count2].Date}");
                Count2++;

            } while (Count2 != customers.Count);





            Console.ReadKey();
		}
	}
}
