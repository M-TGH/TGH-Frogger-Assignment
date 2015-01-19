namespace Frogger
{
    partial class FormHighScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseScoresDataSet1 = new Frogger.DatabaseScoresDataSet1();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoresTableAdapter = new Frogger.DatabaseScoresDataSet1TableAdapters.ScoresTableAdapter();
            this.scoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseScoresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(322, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseScoresDataSet1
            // 
            this.databaseScoresDataSet1.DataSetName = "DatabaseScoresDataSet1";
            this.databaseScoresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoresBindingSource
            // 
            this.scoresBindingSource.DataMember = "Scores";
            this.scoresBindingSource.DataSource = this.databaseScoresDataSet1;
            // 
            // scoresTableAdapter
            // 
            this.scoresTableAdapter.ClearBeforeFill = true;
            // 
            // scoresBindingSource1
            // 
            this.scoresBindingSource1.DataMember = "Scores";
            this.scoresBindingSource1.DataSource = this.databaseScoresDataSet1;
            // 
            // FormHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 195);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormHighScores";
            this.Text = "FormHighScores";
            this.Load += new System.EventHandler(this.FormHighScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseScoresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseScoresDataSet1 databaseScoresDataSet1;
        private System.Windows.Forms.BindingSource scoresBindingSource;
        private DatabaseScoresDataSet1TableAdapters.ScoresTableAdapter scoresTableAdapter;
        private System.Windows.Forms.BindingSource scoresBindingSource1;
    }
}