using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1
{
	internal struct PhoneBook
	{

		#region Attributes

		string[] names;
		long[] numbers;
		int size;

		#endregion

		#region Constructor

		public PhoneBook(int _size)
		{
			size = _size;
			names = new string[size];
			numbers = new long[size];
		}

		#endregion

		#region property

		public int Size // ReadOnly Property
		{
			get { return size; }
		}

		#endregion

		#region Method
		public void AddPerson(int Position, string Name, long Number)
		{
			if (names is not null && numbers is not null)
			{
				if (Position >= 0 && Position < size)
				{
					names[Position] = Name;
					numbers[Position] = Number;
				}
			}
		}
		#endregion

		// Getter
		public long GetNumber(string Name)
		{
			if (names is not null && numbers is not null)
			{
				for (int i = 0; i < names.Length; i++)
				{
					if (Name == names[i])
					{
						return numbers[i];
					}
				}
			}
			return -1;
		}

		// Setter
		public void SetNumber(string Name, long Number)
		{
			if (names is not null && numbers is not null)
			{
				for (int i = 0; i < names.Length; i++)
				{
					if (Name == names[i])
					{
						numbers[i] = Number;
						return;  // return with void : end function == break
					}
				}
			}
		}


		// Indexer : is a Special Parameter
		//           1. Named always with keyword "this"
		//           2. Can Take Parameter

		public long this[string Name]
		{
			get
			{
				if (names is not null && numbers is not null)
				{
					for (int i = 0; i < names.Length; i++)
					{
						if (Name == names[i])
						{
							return numbers[i];
						}
					}
				}
				return -1;
			}
			set
			{
				if (names is not null && numbers is not null)
				{
					for (int i = 0; i < names.Length; i++)
					{
						if (Name == names[i])
						{
							numbers[i] = value;
						}
					}
				}
			}
		}

		public string this[int index]
		{
			get
			{
				return $"Position : {index}, Name : {names[index]}, Number : {numbers[index]} ";
			}
		}

	}
}
