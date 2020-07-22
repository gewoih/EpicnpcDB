using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicnpcDB
{
	public partial class AddPurchase : Form
	{
		private Functions functions = new Functions();
		private int user_id;

		public AddPurchase(int _user_id)
		{
			InitializeComponent();

			user_id = _user_id;

			date_time.CustomFormat = "MM/dd/yyy HH:mm";
		}

		//Кнопка добавления покупки
		private void button1_Click(object sender, EventArgs e)
		{
			if (games_list.Text.Length == 0 || funpay_link.TextLength == 0 || price.Text.Length == 0)
			{
				MessageBox.Show("Заполните все поля!");
				return;
			}

			if (Convert.ToDouble(price.Text) < 0)
			{
				MessageBox.Show("Цена не может быть отрицательной!");
				return;
			}

			if (date_time.Value > DateTime.Now)
			{
				MessageBox.Show("Введите корректную дату!");
				return;
			}

			string query = "INSERT INTO purchases values(" +
			price.Text.Replace(',', '.') + ", \'" + games_list.Text + "\', N\'" +
			description.Text + "\', N\'" + funpay_link.Text + "\', CONVERT(nvarchar, \'" +
			date_time.Text + "\', 113), " + user_id + ", \'False\');";

			functions.create_operation(query);

			MessageBox.Show("Покупка успешно добавлена.");

			this.Close();
		}
	}
}
