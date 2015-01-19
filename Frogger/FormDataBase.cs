using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frogger
{
    public partial class FormDataBase : Form
    {
        public FormDataBase()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseScoresDataSet1);

        }

        private void FormDataBase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseScoresDataSet1.Scores' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.databaseScoresDataSet1.Scores);
            // TODO: This line of code loads data into the 'databaseScoresDataSet.Table' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.databaseScoresDataSet1.Scores);

        }

        private void scoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseScoresDataSet1);

        }
    }
}
