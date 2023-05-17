using System.Data;
using System.Data.SqlClient;
string conn = ''Data Source = DESKTOP-009CALL\SQLEXPRESS;Initial Catalog=employee;Integrated Security=true'';

SqlConnection con = new SqlConnection(conn);

con.Open();

string query = ''SELECT * FROM details'';

SqlCommand cmd = new SqlCommand(query, con);

SqlDataReader reader = cmd.ExecuteReader();

while(reader.Read())
{
//string output = ''Output = '' + reader.GetValue(0) + '' '' + reader.GetValue(1);
//MessageBox.Show(output);

	object[] all = new object[reader.FieldCount];
	reader.GetValues(all);
        for (int i = 0; i < all.Count(); i++)
        {
                MessageBox.Show(all[i].ToString());
        }
}

reader.Close();

cmd.Dispose();

con.Close();

con.Dispose();