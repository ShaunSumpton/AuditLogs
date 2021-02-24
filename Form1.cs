using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class AuditLog : Form
    {
        public AuditLog()
        {
            InitializeComponent();

            Utils.PopulateDataGridView(dataGridView1, "order by counter asc");

            toolStripTextBox1.KeyPress += new KeyPressEventHandler(KeyPressContainer);
            toolStripTextBox2.KeyPress += new KeyPressEventHandler(KeyPressUser);

            comboBox1.Items.Add("Goods In Deliveries");
            comboBox1.DisplayMember = "Goods In Deliveries";


        }

        //MENU STRIP ITEMS (KEY PRESS) //
        private void KeyPressContainer(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
              
                Utils.PopulateDataGridView(dataGridView1, "where Container = '" + toolStripTextBox1.Text + "' order by counter");
            }

        }
        private void KeyPressUser(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {

                Utils.PopulateDataGridView(dataGridView1, "where person = '" + toolStripTextBox2.Text + "' order by counter");
            }

        }
        //REFRESH BUTTON //
        private void button1_Click(object sender, EventArgs e)
        {

            Utils.PopulateDataGridView(dataGridView1, "order by counter asc");

        }

     

    }


}
