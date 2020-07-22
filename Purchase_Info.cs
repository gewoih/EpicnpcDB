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
	public partial class Purchase_Info : Form
	{
		Main_Form main = new Main_Form();
		private Purchase purchase;
		private Functions functions;

		public Purchase_Info(Purchase _purchase)
		{
			InitializeComponent();

			functions = main.functions;
			purchase = _purchase;

			if (_purchase.is_sold == true)
				button1.Enabled = false;

			label8.Text = _purchase.user_id.ToString();
			label9.Text = _purchase.game;
			label10.Text = _purchase.operation_price.ToString();
			label11.Text = _purchase.description;
			label12.Text = _purchase.funpay_order;
			label13.Text = _purchase.operation_date_time.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddSale new_sale = new AddSale(functions, purchase.operation_id);
			new_sale.ShowDialog();
			this.Close();
		}
	}
}
