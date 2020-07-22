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
	public partial class AddWithdrawal : Form
	{
		private Functions functions = new Functions();

		public AddWithdrawal()
		{
			InitializeComponent();

			date_time.CustomFormat = "MM/dd/yyy HH:mm";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (price.Text.Length == 0)
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

			string query = "INSERT INTO withdrawals values(" +
			price.Text.Replace(',', '.') +  ", CONVERT(nvarchar, \'" +
			date_time.Text + "\', 113), \'False\')";

			functions.create_operation(query);

			MessageBox.Show("Вывод средств успешно добавлен.");

			this.Close();
		}
	}
}
