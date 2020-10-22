using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{

/*
 * C# 9.0
 * class
 * struct
*/
		public record Person
        {
<<<<<<< Updated upstream
            Console.WriteLine("dawdawdaw");
            Console.WriteLine("dawdawdaw");

            Console.WriteLine("dawdaw");
=======
			public String Name1 { get; }
			public String Name2 { get; }
			
			public Person() { }
			public Person(String N1, String N2)
				=> (Name1, Name2) = (N1, N2);

            public override string ToString()
				=> $"{Name1 ?? "void"}, {Name2 ?? "void"}";
>>>>>>> Stashed changes
        }

		static void Main(string[] args)
		{
			var s = Console.ReadLine();

			if(s is not null) /// s != null
			{
				if(s.Trim() != "")
				{
					Console.WriteLine("s is not null " + s.ToString());
				}
			}


			if(s?.Trim() != "")
				Console.WriteLine("s is not null " + s.ToString());
			if (!String.IsNullOrEmpty(s?.Trim()))
				Console.WriteLine("s is not null " + s.ToString());

			Nullable<Boolean> a = null;
			Boolean? a1 = null;
			if (!(a1 ?? false))
				Console.WriteLine("a1 is null or false");

			List<Person> people = new() { new Person("1", null), new Person("3", "4"), null };

            foreach (var item in people)
            {
				Console.WriteLine(item);
            }

			people.ForEach(x => Console.WriteLine(x));

			/// x is not null
			var a3 = people.Where(x => x is not null).ToList();

			Console.ReadLine();
		}

		void B(ref int? a) { }
	}
}
