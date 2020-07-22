using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicnpcDB
{
	public class Purchase_Panel : APanel<Purchase>
	{
		public Purchase_Panel(Purchase _new_purchase, Color _main_color) : base(_new_purchase, _main_color)
		{
			text[0].Text = new_item.operation_id.ToString();
			text[1].Text = new_item.user_id.ToString();
			text[2].Text = new_item.operation_price.ToString();
			text[3].Text = new_item.game;
			text[4].Text = new_item.operation_date_time.ToString();
		}

		protected override void panel_on_click(object sender, EventArgs e)
		{
			Purchase_Info info = new Purchase_Info(new_item);
			info.ShowDialog();
		}
	}
}
