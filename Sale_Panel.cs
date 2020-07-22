using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicnpcDB
{
	public class Sale_Panel : APanel<Sale>
	{
		public Sale_Panel(Sale _new_sale, Color _main_color) : base(_new_sale, _main_color)
		{
			text[0].Text = new_item.operation_id.ToString();
			text[1].Text = new_item.purchase.user_id.ToString();
			text[2].Text = new_item.operation_price.ToString();
			text[3].Text = new_item.purchase.game.ToString();
			text[4].Text = new_item.operation_date_time.ToString();
		}

		protected override void panel_on_click(object sender, EventArgs e)
		{
			Sale_Info info = new Sale_Info(new_item);
			info.ShowDialog();
		}
	}
}
