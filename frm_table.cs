using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Callerid_demo
{
    public partial class frm_table : MetroForm
    {
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        DataTable table;
        SqlDataAdapter adapter;
        string connetionString;
        string sql;
        string _table = "";

        public frm_table(string table_name)
        {
            InitializeComponent();
            _table = table_name;
             dgv_table_init();
            
            connetionString = "Data Source=.\\SQL_2014;Initial Catalog=db_ros;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            calculator();

        }

        private void frm_table_Load(object sender, EventArgs e)
        {
            lbl_table.Text = _table;
            this.WindowState = FormWindowState.Normal;
            fill_cmbox();
            fill_dgv_table(_table);
            update_total_and_KDV();
        }
        private void cb_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgv_prod();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            num_buttons_control(true);
        }
        private void btn_erase_Click(object sender, EventArgs e)
        {
            num_buttons_control(false);
        }
        private void num_buttons_control(bool add)
        {
            try
            {
               
                int selectedIndex = -1;
                if ( dgv_table.RowCount > 1)
                {
                    selectedIndex = dgv_table.CurrentRow.Index;
                }


            if (selectedIndex > -1 && dgv_table.CurrentCell.RowIndex < dgv_table.RowCount - 1)
            {
                int id = int.Parse(dgv_table.CurrentRow.Cells[5].Value.ToString());
                int number = int.Parse(dgv_table.CurrentRow.Cells[2].Value.ToString());
                int price = int.Parse(dgv_table.CurrentRow.Cells[4].Value.ToString());
                price /= number;
                if (add)
                {
                    number++;
                }
                else
                {
                    number--;
                }

                price *= number;
                dgv_table.CurrentRow.Cells[2].Value = number;
                dgv_table.CurrentRow.Cells[4].Value = price;
                if (number == 0)
                {
                    dgv_table_clear_selected_row(id);
                }
                else
                {
                    dgv_table_update_selected_row(id, number, price);
                }

            }
            update_total_and_KDV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                throw;
            }
        }
        private void dgv_table_clear_selected_row(int id)
        {
            try
            {

                cnn.Open();
                sql = "DELETE FROM tbl_onetable WHERE onetable_id=" + id + "";
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                dgv_table.Rows.RemoveAt(dgv_table.CurrentRow.Index);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata : " + ex.Message);
                throw;
            }
        }
        private void dgv_table_update_selected_row(int id, int number, int price)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                sql = "UPDATE tbl_onetable SET prod_num=@prod_num,prod_price=@prod_price WHERE onetable_id=@onetable_id";
                command = new SqlCommand(sql, cnn);
                command.Parameters.Add(new SqlParameter("@prod_num", number));
                command.Parameters.Add(new SqlParameter("@prod_price", price));
                command.Parameters.Add(new SqlParameter("@onetable_id", id));
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void fill_cmbox()
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                adapter = new SqlDataAdapter("SELECT * FROM tbl_cat", cnn);
                table = new DataTable();
                adapter.Fill(table);
                adapter.Dispose();
                cnn.Close();
                cb_cat.DataSource = table;
                cb_cat.DisplayMember = "cat_name";

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                throw;
            }
        }
        private void fill_dgv_table(string _table_name)
        {
            try
            {


                string table_name = "", prod_id = "", num = "", name = "", price = "", id = "";


                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }

                sql = "SELECT table_name,tbl_onetable.prod_id,prod_num,prod_name,tbl_onetable.prod_price, onetable_id  FROM tbl_onetable INNER JOIN tbl_prod ON tbl_prod.prod_id=tbl_onetable.prod_id where table_name='" + _table_name + "' ";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    table_name = dataReader["table_name"].ToString();
                    prod_id = dataReader["prod_id"].ToString();
                    num = dataReader["prod_num"].ToString();
                    name = dataReader["prod_name"].ToString();
                    price = dataReader["prod_price"].ToString();
                    id = dataReader["onetable_id"].ToString();
                    string[] row1 = { table_name, prod_id, num, name, price, id };

                    dgv_table.Rows.Add(row1);
                }
                dataReader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void FillDgv_prod()
        {

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            adapter = new SqlDataAdapter("SELECT prod_id,prod_name,prod_price,imagine FROM tbl_prod where cat_name='" + cb_cat.Text + "'", cnn);
            table = new DataTable();
            adapter.Fill(table);
            dgv_prod.RowTemplate.Height = 100;
            dgv_prod.DataSource = table;
            adapter.Dispose();
            cnn.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dgv_prod.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewCellStyle cellstyle = new DataGridViewCellStyle();

            cellstyle.BackColor = Color.White;
            cellstyle.ForeColor = Color.Black;
            cellstyle.SelectionBackColor = Color.Orange;
            cellstyle.Font = new Font("Tahoma", 16);
            dgv_prod.DefaultCellStyle = cellstyle;
            dgv_prod.Columns[0].HeaderText = "ID";
            dgv_prod.Columns[1].HeaderText = "İsim";
            dgv_prod.Columns[2].HeaderText = "Fiyat(₺)";
            dgv_prod.Columns[3].HeaderText = "Resim";

        }
        private void dgv_table_init()
        {
            dgv_table.ColumnCount = 6;
            DataGridViewCellStyle cellstyle = new DataGridViewCellStyle();

            cellstyle.BackColor = Color.Black;
            cellstyle.ForeColor = Color.White;
            cellstyle.SelectionBackColor = Color.Orange;
            cellstyle.Font = new Font("Tahoma", 16);
            dgv_table.DefaultCellStyle = cellstyle;
            dgv_table.ColumnHeadersDefaultCellStyle = cellstyle;
            dgv_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_table.Columns[0].Name = "table_name";
            dgv_table.Columns[1].Name = "prod_id";
            dgv_table.Columns[2].Name = "Adet";
            dgv_table.Columns[3].Name = "Ürün";
            dgv_table.Columns[4].Name = "Fiyat";
            dgv_table.Columns[5].Name = "onetable_id";
            dgv_table.Columns[0].Visible = false;
            dgv_table.Columns[1].Visible = false;
            dgv_table.Columns[5].Visible = false;
        }
        private void calculator()
        {
            foreach (Control rb in pnl_numbers.Controls)
            {
                if (rb is Button)
                {
                    Button bt = (rb as Button);
                    rb.MouseClick += new MouseEventHandler((o, a) => add_number(bt));
                }
            }
        }
        private void add_number(Button btn)
        {
            if (btn.Text != "ok" && btn.Text != "iptal")
            {
                txt_num.Text += btn.Text;
            }
            else if (btn.Text == "ok" && txt_num.Text != "")
            {
                add_item_to_table(int.Parse(txt_num.Text));
                txt_num.Text = "";
                update_total_and_KDV();
            }
            else
            {
                txt_num.Text = "";
            }

        }
        private void add_item_to_table(int _num)
        {

            int selectedIndex = dgv_prod.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                int p = int.Parse(dgv_prod.CurrentRow.Cells[2].Value.ToString());
                string table_name = lbl_table.Text;
                string prod_id = dgv_prod.CurrentRow.Cells[0].Value.ToString();
                string num = _num.ToString();
                string name = dgv_prod.CurrentRow.Cells[1].Value.ToString();
                string price = (_num * p).ToString();
                string[] row = { table_name, prod_id, num, name, price };
                int id = add_to_table_database(row);
                string[] row1 = { table_name, prod_id, num, name, price, id.ToString() };
                dgv_table.Rows.Add(row1);

            }
        }
        private int add_to_table_database(string[] row)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                sql = "INSERT INTO tbl_onetable(table_name,prod_num,prod_id,prod_price)Values(@table_name,@prod_num,@prod_id,@prod_price)";
                command = new SqlCommand(sql, cnn);
                command.Parameters.Add(new SqlParameter("@table_name", row[0]));
                command.Parameters.Add(new SqlParameter("@prod_id", int.Parse(row[1])));
                command.Parameters.Add(new SqlParameter("@prod_num", int.Parse(row[2])));
                command.Parameters.Add(new SqlParameter("@prod_price", int.Parse(row[4])));
                command.ExecuteNonQuery();

                int id = 0;
                sql = "SELECT TOP(1) onetable_id  FROM tbl_onetable  order by onetable_id desc ";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    id = int.Parse(dataReader["onetable_id"].ToString());
                }
                dataReader.Close();
                cnn.Close();
                return id;
            }
            catch (Exception ex)
            {
                cnn.Close();
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void update_total_and_KDV()
        {
            float KDV = 0;
            float total_price = 0;

            for (int i = 0; i < dgv_table.Rows.Count - 1; i++)
            {
                total_price += float.Parse(dgv_table.Rows[i].Cells[4].Value.ToString());

            }
            KDV = (total_price * 18) / 100;
            lbl_total.Text = total_price.ToString();
            lbl_kdv.Text = KDV.ToString();

        }
        private void btn_tableMove_Click(object sender, EventArgs e)
        {
            frm_tableMove Frm_tableMove = new frm_tableMove(lbl_table.Text);
            Frm_tableMove.ShowDialog();
            this.Close();
        }
    }
}
