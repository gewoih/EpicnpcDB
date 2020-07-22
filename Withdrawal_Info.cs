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
	public partial class Withdrawal_Info : Form
	{
		private Main_Form main = new Main_Form();
		private Withdrawal withdrawal;
		private Functions functions;

		public Withdrawal_Info(Withdrawal _withdrawal)
		{
			InitializeComponent();

			withdrawal = _withdrawal;
			functions = main.functions;

			amount.Text = withdrawal.operation_price.ToString();
			date_time.Text = withdrawal.operation_date_time.ToString();
			to_transfer.Text = "0р.";

			if (withdrawal.is_transferred == true)
			{
				is_transferred.BackColor = Color.Lime;
				is_transferred.Text = "Да";
			}
			else
			{
				is_transferred.BackColor = Color.Crimson;
				is_transferred.Text = "Нет";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string query = "UPDATE withdrawals SET transferred = \'True\' WHERE id = " + withdrawal.operation_id;

			functions.create_operation(query);
			functions.update_lists();

			withdrawal.is_transferred = true;

			MessageBox.Show("Перевод успешно выполнен.");
			this.Close();
		}
	}
}
