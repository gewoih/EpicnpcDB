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
	public abstract class APanel_List<T> where T : AOperation
	{
		protected List<T> panels_list = new List<T>();
		protected Functions functions = new Functions();
		virtual protected string query { get; set; } = "SELECT * FROM purchases";

		public void add(T item)
		{
			panels_list.Add(item);
		}

		public int size()
		{
			return panels_list.Count();
		}

		virtual public T this[int index]
		{
			get
			{
				return panels_list[index];
			}
		}

		abstract public void drawing(Panel panel);

		abstract public void update();
	}
}
