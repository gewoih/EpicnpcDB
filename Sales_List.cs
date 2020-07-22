using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicnpcDB
{
	public class Sales_List : APanel_List<Sale>
	{
		public override void drawing(Panel panel)
		{
			panel.Controls.Clear();

			for (int i = 0; i < size(); i++)
			{
				Color color;
				if (i % 2 == 0)
					color = Color.FromName("ControlLight");
				else
					color = Color.FromName("AppWorkspace");

				Sale_Panel sale = new Sale_Panel(panels_list[i], color);
				sale.add_panel(panel);
			}
		}

		public override void update()
		{
			panels_list.Clear();

			string query = "SELECT * FROM sales";

			DataTable sales = functions.create_datatable(query);

			for (int index = 0; index < sales.Rows.Count; index++)
			{
				//Поля для новой продажи
				int sale_id = Convert.ToInt32(sales.Rows[index].ItemArray[0]);
				int purchase_id = Convert.ToInt32(sales.Rows[index].ItemArray[1]);
				double sell_price = Convert.ToDouble(sales.Rows[index].ItemArray[2]);
				string buyer_discord = sales.Rows[index].ItemArray[3].ToString();
				string paypal_operation_id = sales.Rows[index].ItemArray[4].ToString();
				DateTime sale_date_time = Convert.ToDateTime(sales.Rows[index].ItemArray[5]);

				query = "SELECT * FROM purchases WHERE id = " + purchase_id;
				DataTable purchase_table = functions.create_datatable(query);

				//Поля для покупки, на которой будет основана продажа
				double purchase_price = Convert.ToInt32(purchase_table.Rows[0].ItemArray[1]);
				string purchase_game = purchase_table.Rows[0].ItemArray[2].ToString();
				string purchase_description = purchase_table.Rows[0].ItemArray[3].ToString();
				string purchase_funpay_link = purchase_table.Rows[0].ItemArray[4].ToString();
				DateTime purchase_date_time = Convert.ToDateTime(purchase_table.Rows[0].ItemArray[5]);
				int purchase_user_id = Convert.ToInt32(purchase_table.Rows[0].ItemArray[6]);

				Purchase purchase = new Purchase(purchase_id, purchase_price, purchase_game, purchase_description,
												 purchase_funpay_link, purchase_date_time, purchase_user_id, true);

				add(new Sale(sale_id, purchase, sell_price, buyer_discord, paypal_operation_id, sale_date_time));
			}
		}
	}
}
