using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3.Interfaces
{
	interface ISeries
	{
		int Current { get; set; }

		void GetNext();

		public void Reset()  // Default Implement Method
		{
			Current = 0;
		}
	}

	class SeriesByTwo : ISeries
	{
		public int Current { get; set; }

		public void GetNext()
		{
			Current += 2;
		}
	}

	class SeriesByThree : ISeries
	{
		public int Current { get; set; }

		public void GetNext()
		{
			Current += 3;
		}
	}
}
