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
    class Utils
    {


        public static void PopulateDataGridView(DataGridView DGV, string sql)
        {

            string connstr;
            connstr = @"";
            SqlConnection con = new SqlConnection(connstr);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from GoodsInDel_Audit " + sql;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            
                sqlDataAdap.Fill(dtRecord);

                if (dtRecord.Rows.Count == 0) return;

                DGV.DataSource = dtRecord;
          
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }



    }
}
