using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicnpcDB
{
	public class Sale : AOperation
	{
		public Purchase purchase { get; }
		public string buyer_discord { get; }
		public string paypal_operation_id { get; }
		public double profit { get; }
		public int term { get; }
		public Sale(int _sale_id, Purchase _purchase, double _sale_price, 
					string _buyer_discord, string _paypal_operation_id,
					DateTime _sale_date_time) : base(_sale_id, _sale_price, _sale_date_time)
		{
			purchase = _purchase;
			buyer_discord = _buyer_discord;
			paypal_operation_id = _paypal_operation_id;
			profit = operation_price - purchase.operation_price;
			term = operation_date_time.Day - purchase.operation_date_time.Day;
		}
	}
}
