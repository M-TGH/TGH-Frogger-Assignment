using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Frogger
{
    public partial class FormHighScores : Form
    {
        public FormHighScores()
        {
            InitializeComponent();
            string selectComm = "SELECT TOP 5 Name, Score, Date FROM Scores ORDER BY Score DESC";

            DataSet data = new DataSet();
            try
            {
                //Get scores
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\School\Jaar_2\C#\C-Sharp-Frogger-master\Frogger\DatabaseScores.mdf;Integrated Security=True");
                SqlCommand command = new SqlCommand(selectComm, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(data, "Scores");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Scores";

            //DataTableCollection dta = data.Tables;
            //foreach (DataTable dt in dta)
            //{
            //    MessageBox.Show(String.Format("Found data table {0}", dt.TableName));
            //}

            //DataColumnCollection drc = data.Tables["Scores"].Columns;
            //int i = 0;
            //foreach (DataColumn dc in drc)
            //{
            //    MessageBox.Show(String.Format("Column name[{0}] is {1}, of type {2}", i++, dc.ColumnName, dc.DataType));
            //}

            //dataGridView1.DataSource = this.databaseScoresDataSet1;
            //dataGridView1.DataMember = "Scores";
        }

        private void FormHighScores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseScoresDataSet1.Scores' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.databaseScoresDataSet1.Scores);

        }
    }
}
