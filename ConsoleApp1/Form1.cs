using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void instructorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.timetableDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableDBDataSet21.IT' table. You can move, or remove it, as needed.
            this.iTTableAdapter.Fill(this.timetableDBDataSet21.IT);
            // TODO: This line of code loads data into the 'timetableDBDataSet11.Instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter1.Fill(this.timetableDBDataSet11.Instructors);
            // TODO: This line of code loads data into the 'timetableDBDataSet.Instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.timetableDBDataSet.Instructors);

        }

        private void instructorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.instructorsTableAdapter.FillBy(this.timetableDBDataSet.Instructors);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
