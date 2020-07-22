using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicnpcDB
{
	public class Withdrawal_Panel : APanel<Withdrawal>
	{
		public Withdrawal_Panel(Withdrawal _new_withdrawal, Color _main_color) : base(_new_withdrawal, _main_color)
		{
			text[0].Text = new_item.operation_id.ToString();
			text[1].Text = new_item.operation_price.ToString();
			text[2].Text = new_item.operation_date_time.ToString();
			text[3].Text = _new_withdrawal.is_transferred.ToString();
		}

		protected override void panel_on_click(object sender, EventArgs e)
		{
			Withdrawal_Info info = new Withdrawal_Info(new_item);
			info.ShowDialog();
		}
	}
}
