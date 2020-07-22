using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EpicnpcDB
{
	public partial class AddSale : Form
	{
		static private int purchase_id;
		private string query;

		private Functions functions;

		public AddSale(Functions _functions, int _purchase_id)
		{
			InitializeComponent();

			functions = _functions;
			purchase_id = _purchase_id;

			date_time.CustomFormat = "MM/dd/yyyy HH:mm";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (sell_price.Text.Length == 0 || buyer_discord.Text.Length == 0 || paypal_operation_id.Text.Length == 0)
			{
				MessageBox.Show("Заполните все поля!");
				return;
			}

			if (Convert.ToDouble(sell_price.Text) < 0)
			{
				MessageBox.Show("Цена не может быть отрицательной!");
				return;
			}

			if (date_time.Value > DateTime.Now)
			{
				MessageBox.Show("Введите корректную дату!");
				return;
			}

			query = "INSERT INTO sales values(" + purchase_id.ToString() + ", " +
				sell_price.Text.Replace(',', '.') + ", \'" + buyer_discord.Text + "\', \'" +
				paypal_operation_id.Text + "\', CONVERT(nvarchar, \'" + date_time.Text + "\', 113));";
			functions.create_operation(query);

			query = "UPDATE purchases SET sold = \'True\' WHERE id = " + purchase_id;
			functions.create_operation(query);

			functions.update_lists();

			MessageBox.Show("Продажа добавлена.");

			this.Close();
		}
	}
}
