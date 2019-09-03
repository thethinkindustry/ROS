using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Callerid_demo
{
    public partial class frm_tableMove : MetroForm
    {
        SqlCommand command;
        SqlDataReader dataReader;
        DataTable table;
        SqlDataAdapter adapter;
        DataView dv;
        string table_name = "";
        string sql = "";
        string connetionString;
        public frm_tableMove(string _table_name)
        {
            InitializeComponent();
            table_name = _table_name;
            DatabaseManager.Connect();
            fill_tables();
        }
        void fill_tables()
        {
            int tables = 18;
            try
            {
                if (DatabaseManager.connection.State == ConnectionState.Closed)
                {
                    DatabaseManager.Open();
                }
                adapter = new SqlDataAdapter("SELECT * FROM tbl_tables ORDER BY table_name", DatabaseManager.connection);
                table = new DataTable();
                adapter.Fill(table);
                tables = table.Rows.Count;
                int counter = 0;
                int x = 6;
                int y = 0;
                int g = 0;
                int table_id = 0;
                for (int i = 0; i < tables; i++)
                {
                    counter++;
                    Button button = new Button();
                    if (g >= x)
                    {
                        g = 0;
                        y += 100;

                    }
                    button.Location = new System.Drawing.Point(g * 200, y);
                    button.Size = new System.Drawing.Size(200, 100);
                    button.BackColor = System.Drawing.Color.DimGray;
                    button.Text = table.Rows[i][1].ToString();
                    button.Name = table.Rows[i][1].ToString();
                    table_id = (int)table.Rows[i][0];
                    button.ForeColor = Color.White;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Microsoft Sans Serif", 36);
                    button.Click += new EventHandler(DynamicButton_Click);
                    this.pnl.Controls.Add(button);

                    g++;
                }
                adapter.Dispose();
                DatabaseManager.Close();
                is_table_busy();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                throw;
            }



        }
        private void is_table_busy()
        {
            foreach (Control ctrl in this.pnl.Controls)
            {
                if (ctrl is Button)
                {

                    if (DatabaseManager.connection.State == ConnectionState.Closed)
                    {
                        DatabaseManager.Open();
                    }
                    adapter = new SqlDataAdapter("SELECT * FROM tbl_onetable where table_name='" + ctrl.Name + "'", DatabaseManager.connection);
                    table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        ctrl.BackColor = Color.Orange;
                        ctrl.ForeColor = Color.Black;
                    }
                    else
                    {
                        ctrl.BackColor = Color.DimGray;
                        ctrl.ForeColor = Color.White;
                    }
                    adapter.Dispose();
                    DatabaseManager.Close();
                }
            }
        }
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            movetable(clickedButton.Text);

        }
        private void movetable(string clickedButton)
        {
            try
            {
                if (DatabaseManager.connection.State == ConnectionState.Closed)
                {
                    DatabaseManager.Open();
                }

                sql = "UPDATE tbl_onetable SET table_name=@table_name WHERE table_name='" + table_name + "'";
                command = new SqlCommand(sql, DatabaseManager.connection);
                command.Parameters.Add(new SqlParameter("@table_name", clickedButton));
                command.ExecuteNonQuery();
                command.Dispose();
                DatabaseManager.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
