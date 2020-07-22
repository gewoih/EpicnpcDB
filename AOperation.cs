using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicnpcDB
{
	public abstract class AOperation
	{
		public int operation_id { get; }
		public double operation_price { get; }
		public DateTime operation_date_time { get; }

		public AOperation(int _operation_id, double _operation_price, DateTime _operation_date_time)
		{
			operation_id = _operation_id;
			operation_price = _operation_price;
			operation_date_time = _operation_date_time;
		}
	}
}
