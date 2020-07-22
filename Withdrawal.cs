using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicnpcDB
{
	public class Withdrawal : AOperation
	{
		public bool is_transferred { get; set; }

		public Withdrawal(int _withdraw_id, double _withdraw_price, DateTime _withdraw_date_time) : 
				 base (_withdraw_id, _withdraw_price, _withdraw_date_time)
		{
			is_transferred = false;
		}
	}
}
