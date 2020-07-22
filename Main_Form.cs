using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicnpcDB
{
	public partial class Main_Form : Form
	{
		public Purchases_List list_of_purchases { get; } = new Purchases_List();
		public Stocks_List list_of_stocks { get; } = new Stocks_List();
		public Sales_List list_of_sales { get; } = new Sales_List();
		public Withdrawals_List list_of_withdrawals { get; } = new Withdrawals_List();
		public List<Action> actions { get; }
		public Functions functions { get; }

		private int user_id;

		public Main_Form()
		{
			InitializeComponent();

			actions = new List<Action>()
			{ list_of_purchases.update, list_of_stocks.update, list_of_sales.update, list_of_withdrawals.update };
			functions = new Functions(actions);

			functions.update_lists();
		}

		//Кнопка авторизации
		private void button1_Click(object sender, EventArgs e)
		{
			string login = textBox1.Text;
			string password = textBox2.Text;

			if (login.Length == 0 || password.Length == 0)
			{
				MessageBox.Show("Введите имя пользователя и пароль!");
				return;
			}

			string query = "SELECT * FROM users WHERE user_name = N\'" + login + "\'";

			DataTable table = functions.create_datatable(query);

			if (table.Rows.Count == 0 || table.Rows[0].ItemArray[2].ToString() != password)
				MessageBox.Show("Неверный логин или пароль.");
			else
			{
				MessageBox.Show("Успешный вход.");

				change_list.SelectedIndex = 0;
				auth_panel.Visible = false;
				user_id = Convert.ToInt32(table.Rows[0].ItemArray[0]);
			}
		}

		//Событие при смене индекса combobox
		private void change_list_SelectedIndexChanged(object sender, EventArgs e)
		{
			add_purchase_button.Visible = false;
			add_withdrawal_button.Visible = false;

			if (change_list.SelectedIndex == 0)
			{
				list_of_purchases.drawing(panel1);
				add_purchase_button.Visible = true;
			}

			else if (change_list.SelectedIndex == 1)
			{
				list_of_stocks.drawing(panel1);
			}

			else if (change_list.SelectedIndex == 2)
			{
				list_of_sales.drawing(panel1);
			}

			else if (change_list.SelectedIndex == 3)
			{
				list_of_withdrawals.drawing(panel1);
				add_withdrawal_button.Visible = true;
			}
		}

		//Кнопка добавления покупки
		private void add_purchase_button_Click(object sender, EventArgs e)
		{
			AddPurchase new_purchase = new AddPurchase(user_id);
			new_purchase.ShowDialog();

			functions.update_lists();
		}

		//Кнопка добавления вывода средств
		private void add_withdrawal_button_Click(object sender, EventArgs e)
		{
			AddWithdrawal new_withdrawal = new AddWithdrawal();
			new_withdrawal.ShowDialog();

			functions.update_lists();
		}

		//Перемещение формы за верхнюю панель
		private int iFormX, iFormY, iMouseX, iMouseY;
		private void top_border_panel_MouseMove(object sender, MouseEventArgs e)
		{
			int iMouseX2 = MousePosition.X;
			int iMouseY2 = MousePosition.Y;
			if (e.Button == MouseButtons.Left)
				this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
		}

		private void top_border_panel_MouseDown(object sender, MouseEventArgs e)
		{
			iFormX = this.Location.X;
			iFormY = this.Location.Y;
			iMouseX = MousePosition.X;
			iMouseY = MousePosition.Y;
		}
	}
}
