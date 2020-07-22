using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicnpcDB
{
	public partial class Sale_Info : Form
	{
		public Sale_Info(Sale _sale)
		{
			InitializeComponent();

			buyer_name.Text = _sale.purchase.user_id.ToString();
			game.Text = _sale.purchase.game;
			purchase_price.Text = _sale.purchase.operation_price.ToString();
			purchase_description.Text = _sale.purchase.description;
			funpay.Text = _sale.purchase.funpay_order;
			purchase_date_time.Text = _sale.purchase.operation_date_time.ToString();

			sell_price.Text = _sale.operation_price.ToString();
			buyer_discord.Text = _sale.buyer_discord;
			paypal_operation_id.Text = _sale.paypal_operation_id;
			sell_date_time.Text = _sale.operation_date_time.ToString();

			profit.Text = _sale.profit.ToString() + "р.";
			in_days.Text = _sale.term.ToString() + " дней";
		}
	}
}
