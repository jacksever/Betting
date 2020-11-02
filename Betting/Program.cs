using Betting.Data;
using Betting.Data.Models;
using System;
using System.Linq;

namespace Betting
{
	public class Program
	{
		public static readonly BeetingContext context = new BeetingContext();

		static void Main(string[] args)
		{
			User user = new User()
			{
				Name = "Denis",
				Balance = 2000,
				Email = "test@test.ru",
				Password = "1234",
				Username = "DSNGH"
			};

			//context.Users.Add(user);
			//context.SaveChanges();

			var users = context.Users
				.ToList();

			foreach (var u in users)
				Console.WriteLine("{0} {1} {2} {3}", u.Name, u.Email, u.Balance, u.Password);
			
		}
	}
}
