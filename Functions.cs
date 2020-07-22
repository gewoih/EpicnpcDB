using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicnpcDB
{
	public class Functions
	{
		private List<Action> updates = new List<Action>();
		//private string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Main DB;Integrated Security=True";
		private string connection_string = "Data Source=u1106405.plsk.regruhosting.ru;Initial Catalog=u1106405_epicnpc;Integrated Security=False;User ID=u1106405_gewoih;Password=24042001Nr";

		public Functions()
		{ }

		public Functions(List<Action> _updates)
		{
			updates = _updates;
		}

		public DataTable create_datatable(string query)
		{
			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				DataTable new_datatable = new DataTable();
				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

				adapter.Fill(new_datatable);
				return new_datatable;
			}
		}

		public void create_operation(string query)
		{
			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				SqlCommand adapter = new SqlCommand(query, connection);
				adapter.Connection.Open();
				adapter.ExecuteNonQuery();
			}
		}

		public void update_lists()
		{
			for (int i = 0; i < updates.Count; i++)
				updates[i]();
		}
	}
}
