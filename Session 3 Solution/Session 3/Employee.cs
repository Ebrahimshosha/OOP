using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
	internal class Employee
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int Age { get; set; }

		public void MyFun1()
		{
			Console.WriteLine("I am Employee");
		}

		public virtual void MyFun2()
		{
			Console.WriteLine($"Employee : Id = {Id}, Name = {Name}, age = {Age}");
		}
	}

	class FullTimeEmployeee : Employee
	{
		public decimal Salary { get; set; }

		public new void MyFun1()
		{
			Console.WriteLine("I am Full Employee");
		}

		public override void MyFun2()
		{
			Console.WriteLine($"Employee : Id = {Id}, Name = {Name}, age = {Age}, salary = {Salary}");
		}
	}

	class PartTimeEmployeee : Employee
	{
		public decimal HourRate { get; set; }

		public int CountOfHours { get; set; }

		public new void MyFun1()
		{
			Console.WriteLine("I am Full Employee");
		}

		public override void MyFun2()
		{
			Console.WriteLine($"Employee : Id = {Id}, Name = {Name}, age = {Age}, HourRate = {HourRate}, CountOfHours = {CountOfHours}");
		}
	}


}
