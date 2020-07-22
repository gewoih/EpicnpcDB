using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicnpcDB
{
	public abstract class APanel<T> where T : AOperation
	{
		protected T new_item;
		protected Panel panel = new Panel();
		protected Label[] text = new Label[5];
		protected Color main_color;
		protected Color hover_color = Color.Bisque;

		public APanel(T _new_item, Color _main_color)
		{
			new_item = _new_item;
			main_color = _main_color;

			for (int i = 0; i < 5; i++)
				text[i] = new Label();
		}

		public virtual void add_panel(Control parent)
		{
			panel.Cursor = Cursors.Hand;
			panel.Click += panel_on_click;
			panel.MouseEnter += panel_mouse_enter;
			panel.MouseLeave += panel_mouse_leave;

			panel.Height = 64;
			panel.Dock = DockStyle.Top;
			panel.BackColor = main_color;

			for (int i = 0; i < text.Length; i++)
			{
				text[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				text[i].AutoSize = false;
				text[i].Font = new Font("Arial Black", 12, FontStyle.Bold);

				text[i].MouseEnter += panel_mouse_enter;
				text[i].MouseLeave += panel_mouse_leave;
				text[i].Click += panel_on_click;

				panel.Controls.Add(text[i]);
			}

			text[0].Size = new Size(54, 23);
			text[1].Size = new Size(141, 23);
			text[2].Size = new Size(92, 23);
			text[3].Size = new Size(168, 23);
			text[4].Size = new Size(189, 23);

			text[0].Location = new Point(42, 20);
			text[1].Location = new Point(130, 20);
			text[2].Location = new Point(300, 20);
			text[3].Location = new Point(412, 20);
			text[4].Location = new Point(594, 20);

			parent.Controls.Add(panel);
		}

		abstract protected void panel_on_click(object sender, EventArgs e);

		//Изменение цвета панели при наведении мышью
		protected void panel_mouse_enter(object sender, EventArgs e)
		{
			panel.BackColor = hover_color;
		}

		protected void panel_mouse_leave(object sender, EventArgs e)
		{
			panel.BackColor = main_color;
		}
	}
}
