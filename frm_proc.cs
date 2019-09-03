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
    public partial class frm_proc : MetroForm
    {

        SqlCommand command;
        SqlDataReader dataReader;
        DataTable table;
        SqlDataAdapter adapter;
        string connetionString;
        string sql;
        string _table = "";
        public frm_proc()
        {
            InitializeComponent();
            DatabaseManager.Connect();
        }
        private void frm_proc_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            calculator();
        }
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    fill_tables();
                    break;
                case 1:
                    fill_cmbox();
                    break;
                case 2:
                    break;
                case 3:
                    this.Close();
                    break;
                default:
                    break;
            }
           
        }
        void fill_cmbox()
        {
            try
            {
                if (DatabaseManager.connection.State == ConnectionState.Closed)
                {
                    DatabaseManager.Open();
                }
                adapter = new SqlDataAdapter("SELECT * FROM tbl_cat", DatabaseManager.connection);
                table = new DataTable();
                adapter.Fill(table);
                adapter.Dispose();
                DatabaseManager.Close();
                cb_cat.DataSource = table;
                cb_cat.DisplayMember = "cat_name";

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                throw;
            }
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
                int table_id =0;
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
                    table_id =  (int)table.Rows[i][0];
                    button.ForeColor = Color.White;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Microsoft Sans Serif", 36);
                    button.Click += new EventHandler(DynamicButton_Click);
                    this.metroTabPage1.Controls.Add(button);

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
            foreach (Control ctrl in metroTabPage1.Controls)
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
        private void DynamicButton_Click(object sender, EventArgs e){
            Button clickedButton = (Button)sender;
            frm_table Frm_table = new frm_table(clickedButton.Text);
            Frm_table.ShowDialog();
            is_table_busy();

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
                if (dgv_table.RowCount > 1)
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

                DatabaseManager.Open();
                sql = "DELETE FROM tbl_onetable WHERE onetable_id=" + id + "";
                command = new SqlCommand(sql, DatabaseManager.connection);
                command.ExecuteNonQuery();
                command.Dispose();
                DatabaseManager.Close();
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
                if (DatabaseManager.connection.State == ConnectionState.Closed)
                {
                    DatabaseManager.Open();
                }
                sql = "UPDATE tbl_onetable SET prod_num=@prod_num,prod_price=@prod_price WHERE onetable_id=@onetable_id";
                command = new SqlCommand(sql, DatabaseManager.connection);
                command.Parameters.Add(new SqlParameter("@prod_num", number));
                command.Parameters.Add(new SqlParameter("@prod_price", price));
                command.Parameters.Add(new SqlParameter("@onetable_id", id));
                command.ExecuteNonQuery();
                command.Dispose();
                DatabaseManager.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
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
        private void cb_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgv_prod();
        }
        private void FillDgv_prod()
        {

            if (DatabaseManager.connection.State == ConnectionState.Closed)
            {
                DatabaseManager.Open();
            }
            adapter = new SqlDataAdapter("SELECT prod_id,prod_name,prod_price,imagine FROM tbl_prod where cat_name='" + cb_cat.Text + "'", DatabaseManager.connection);
            table = new DataTable();
            adapter.Fill(table);
            dgv_prod.RowTemplate.Height = 100;
            dgv_prod.DataSource = table;
            adapter.Dispose();
            DatabaseManager.Close();
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
        private void calculator()
        {
            foreach (Control rb in this.pnl_numbers.Controls)
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
               // add_item_to_table(int.Parse(txt_num.Text));
                txt_num.Text = "";
                update_total_and_KDV();
            }
            else
            {
                txt_num.Text = "";
            }

        }
    }
}
