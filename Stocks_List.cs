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
	public class Stocks_List : APanel_List<Purchase>
	{
		protected override string query { get; set; } = "SELECT * FROM purchases WHERE sold = \'False\'";

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

				Purchase_Panel sale = new Purchase_Panel(panels_list[i], color);
				sale.add_panel(panel);
			}
		}

		public override void update()
		{
			panels_list.Clear();

			DataTable purchases = functions.create_datatable(query);

			for (int index = 0; index < purchases.Rows.Count; index++)
			{
				int purchase_id;
				bool sold;
				int user_id;
				string game, description, funpay_order;
				double price;
				DateTime date_time;

				purchase_id = Convert.ToInt32(purchases.Rows[index].ItemArray[0]);
				price = Convert.ToDouble(purchases.Rows[index].ItemArray[1]);
				game = purchases.Rows[index].ItemArray[2].ToString();
				description = purchases.Rows[index].ItemArray[3].ToString();
				funpay_order = purchases.Rows[index].ItemArray[4].ToString();
				date_time = Convert.ToDateTime(purchases.Rows[index].ItemArray[5]);
				user_id = Convert.ToInt32(purchases.Rows[index].ItemArray[6]);
				sold = Convert.ToBoolean(purchases.Rows[index].ItemArray[7]);

				add(new Purchase(purchase_id, price, game, description, funpay_order, date_time, user_id, sold));
			}
		}
	}
}
