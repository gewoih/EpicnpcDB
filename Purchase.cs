using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicnpcDB
{
	public class Purchase : AOperation
	{
		public bool is_sold { get; }
		public int user_id { get; }
		public string game { get; }
		public string description { get; }
		public string funpay_order { get; }

		public Purchase(int _purchase_id, double _price, string _game, string _description, 
						string _funpay_order, DateTime _date_time, int _user_id, bool _is_sold) : base(_purchase_id, _price, _date_time)
		{
			is_sold = _is_sold;
			user_id = _user_id;
			game = _game;
			description = _description;
			funpay_order = _funpay_order;
		}
	}
}
