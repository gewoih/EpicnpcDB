using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicnpcDB
{
	public class Withdrawals_List : APanel_List<Withdrawal>
	{
		protected override string query { get; set; } = "SELECT * FROM withdrawals";

		public override void update()
		{
			panels_list.Clear();

			DataTable purchases = functions.create_datatable(query);

			for (int index = 0; index < purchases.Rows.Count; index++)
			{
				int withdrawal_id;
				double withdrawal_price;
				DateTime withdrawal_date_time;

				withdrawal_id = Convert.ToInt32(purchases.Rows[index].ItemArray[0]);
				withdrawal_price = Convert.ToDouble(purchases.Rows[index].ItemArray[1]);
				withdrawal_date_time = Convert.ToDateTime(purchases.Rows[index].ItemArray[2]);

				add(new Withdrawal(withdrawal_id, withdrawal_price, withdrawal_date_time));
			}
		}

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

				Withdrawal_Panel withdraw = new Withdrawal_Panel(panels_list[i], color);
				withdraw.add_panel(panel);
			}
		}
	}
}
