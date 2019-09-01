using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MetroFramework;

namespace Callerid_demo
{
    public partial class frm_settings : MetroForm
    {
        string imgLoc;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        DataTable table;
        SqlDataAdapter adapter;
        DataView dv;
        string connetionString;
        string sql;
        public frm_settings()
        {
            InitializeComponent();
            connetionString = "Data Source=.\\SQL_2014;Initial Catalog=db_ros;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
        }

        private void frm_settings_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 3;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    try
                    {
                        if (cnn.State == ConnectionState.Closed)
                        {
                            cnn.Open();
                        }
                        adapter = new SqlDataAdapter("SELECT * FROM tbl_tables", cnn);
                        table = new DataTable();
                        adapter.Fill(table);
                        dgv_tables.DataSource = table;
                        adapter.Dispose();
                        cnn.Close();
                        dgv_tables.Columns[0].HeaderText = "ID";
                        dgv_tables.Columns[1].HeaderText = "Masa Numarası";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.Message);
                        throw;
                    }

                    break;
                case 1:
                    try
                    {
                        if (cnn.State == ConnectionState.Closed)
                        {
                            cnn.Open();
                        }
                        adapter = new SqlDataAdapter("SELECT * FROM tbl_cat", cnn);
                        table = new DataTable();
                        adapter.Fill(table);
                        dgv_cat.DataSource = table;
                        adapter.Dispose();
                        cnn.Close();
                        cb_cat.DataSource = table;
                        cb_cat.DisplayMember = "cat_name";
                        dgv_cat.Columns[0].HeaderText = "ID";
                        dgv_cat.Columns[1].HeaderText = "Katagori";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.Message);
                        throw;
                    }
                    break;
                default:
                    break;
            }

        }

        private void btn_addtable_Click(object sender, EventArgs e)
        {
           
            if (txt_table.Text != "" && table_control(txt_table.Text))
            {
              
                try
                {
                    cnn.Open();
                    sql = "INSERT tbl_tables(table_name) VALUES(@tbl_name)";
                    command = new SqlCommand(sql, cnn);
                    command.Parameters.Add(new SqlParameter("@tbl_name", txt_table.Text));
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    metroTabControl1_SelectedIndexChanged(sender, e);
                }
                catch (Exception ex)
                {

                    cnn.Close();
                    MessageBox.Show("Hata " + ex);

                }
            }
        }

        private bool table_control(string text)
        {
            for (int i = 0; i < dgv_tables.RowCount-1; i++)
            {
                if (text==dgv_tables.Rows[i].Cells[1].Value.ToString())
                {
                    
                    MetroMessageBox.Show(this,text+" isminde bir masa bulunmakta !"  );
                    return false;
                }
            }
            return true;
        }

        private void btn_deltable_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_tables.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                try
                {
                    int table_id = int.Parse(dgv_tables.CurrentRow.Cells[0].Value.ToString());
                    cnn.Open();
                    sql = "DELETE FROM tbl_tables  WHERE table_id=" + table_id + "";
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    metroTabControl1_SelectedIndexChanged(sender, e);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata : " + ex.Message);
                    throw;
                }
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|JPEG Files(*jpeg)|*jpeg|All Files(*.*)|*.*";
                dlg.Title = "Ürün Fotoğrafı Seç";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picProd.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata :" + ex);
                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_prod_price_TextChanged(object sender, EventArgs e)
        {

        }
        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&  e.KeyChar != '.';
        }

        private void btn_prod_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_prod_name.Text) || !string.IsNullOrEmpty(txt_prod_price.Text))
            {


                try
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }
                    byte[] img = null;
                    if (!string.IsNullOrEmpty(imgLoc))
                    {
                        FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                    }
                    else
                    {
                       img= ImageToByte(picProd.Image);
                    }
                        sql = "INSERT INTO tbl_prod(cat_name,imagine,prod_name,prod_price)Values(@cat_name,@imagine,@prod_name,@prod_price)";
                        command = new SqlCommand(sql, cnn);
                        command.Parameters.Add(new SqlParameter("@cat_name", cb_cat.Text));
                        command.Parameters.Add(new SqlParameter("@imagine", img));
                        command.Parameters.Add(new SqlParameter("@prod_name", txt_prod_name.Text));
                        command.Parameters.Add(new SqlParameter("@prod_price", int.Parse(txt_prod_price.Text)));
                        int x = command.ExecuteNonQuery();
                        cnn.Close();
                        MessageBox.Show(x.ToString() + "ürün eklendi.");

                        FillDgv_prod();
                    
                   
                   
                }
                catch (Exception ex)
                {
                    cnn.Close();
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void dgv_cat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDgv_prod();
        }
        void FillDgv_prod()
        {

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            adapter = new SqlDataAdapter("SELECT prod_id,prod_name,prod_price,imagine FROM tbl_prod where cat_name='" + dgv_cat.CurrentRow.Cells[1].Value.ToString() + "'", cnn);
            table = new DataTable();
            adapter.Fill(table);
            dgv_prod.RowTemplate.Height = 100;
            dgv_prod.DataSource = table;
            adapter.Dispose();
            cnn.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dgv_prod.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgv_prod.Columns[0].HeaderText = "ID";
            dgv_prod.Columns[1].HeaderText = "İsim";
            dgv_prod.Columns[2].HeaderText = "Fiyat(₺)";
            dgv_prod.Columns[3].HeaderText = "Resim";

        }

        private void btn_cat_add_Click(object sender, EventArgs e)
        {
            if (txt_cat.Text != "")
            {
                try
                {
                    cnn.Open();
                    sql = "INSERT tbl_cat(cat_name) VALUES(@cat_name)";
                    command = new SqlCommand(sql, cnn);
                    command.Parameters.Add(new SqlParameter("@cat_name", txt_cat.Text));
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    metroTabControl1_SelectedIndexChanged(sender, e);
                    txt_cat.Clear();
                }
                catch (Exception ex)
                {

                    cnn.Close();
                    MessageBox.Show("Hata " + ex);

                }
            }
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private void btn_cat_dell_Click(object sender, EventArgs e)
        {

            string cat_name = dgv_cat.CurrentRow.Cells[1].Value.ToString();
            DialogResult ms = MetroMessageBox.Show(this, cat_name + " adlı katagoriyi istediğinizden emin misiniz ?", "Uyarı!", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (ms == DialogResult.Yes)
            {
                int selectedIndex = dgv_cat.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    try
                    {
                        int cat_id = int.Parse(dgv_cat.CurrentRow.Cells[0].Value.ToString());
                        cnn.Open();
                        sql = "DELETE FROM tbl_cat  WHERE cat_id=" + cat_id + "";
                        command = new SqlCommand(sql, cnn);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        cnn.Close();
                        metroTabControl1_SelectedIndexChanged(sender, e);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Hata : " + ex.Message);
                        throw;
                    }
                }
            }
        }

        private void dgv_prod_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_prod.CurrentCell.RowIndex>-1&&dgv_prod.CurrentCell.RowIndex<dgv_prod.RowCount-1)
            {
                cb_cat.Text = dgv_cat.CurrentRow.Cells[1].Value.ToString();
                txt_prod_name.Text = dgv_prod.CurrentRow.Cells[1].Value.ToString();
                txt_prod_price.Text = dgv_prod.CurrentRow.Cells[2].Value.ToString();

                Byte[] data = new Byte[0];
                data = (Byte[])(dgv_prod.CurrentRow.Cells[3].Value);        // tablodaki coloum ismi
                MemoryStream mem = new MemoryStream(data);
                picProd.Image = Image.FromStream(mem);
            }
           
        }

        private void btn_prod_dell_Click(object sender, EventArgs e)
        {
            string prod_name = dgv_prod.CurrentRow.Cells[1].Value.ToString();
            DialogResult ms = MetroMessageBox.Show(this, prod_name + " adlı ürünü istediğinizden emin misiniz ?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (ms == DialogResult.Yes)
            {
                int selectedIndex = dgv_prod.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    try
                    {
                        int id =int.Parse( dgv_prod.CurrentRow.Cells[0].Value.ToString());
                        cnn.Open();
                        sql = "DELETE FROM tbl_prod  WHERE prod_id='" + id + "'";
                        command = new SqlCommand(sql, cnn);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        cnn.Close();
                        metroTabControl1_SelectedIndexChanged(sender, e);
                        txt_prod_name.Clear();
                        txt_prod_price.Clear();
                        picProd.Image = Callerid_demo.Resource_picture.noimage;
                        FillDgv_prod();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Hata : " + ex.Message);
                        throw;
                    }
                }
            }
            }

        private void btn_prod_update_Click(object sender, EventArgs e)
        {
            if (dgv_prod.CurrentCell.RowIndex > -1 && dgv_prod.CurrentCell.RowIndex < dgv_prod.RowCount - 1)
            {
                try
                {
                    byte[] img = ImageToByte(picProd.Image);
                    if (cnn.State==ConnectionState.Closed)
                    {
                        cnn.Open();
                    }
                    sql = "UPDATE tbl_prod SET prod_name=@prod_name,prod_price=@prod_price,cat_name=@cat_name,imagine=@image WHERE prod_id=@prod_id";
                    command = new SqlCommand(sql, cnn);
                    command.Parameters.Add(new SqlParameter("@prod_name", txt_prod_name.Text));
                    command.Parameters.Add(new SqlParameter("@prod_price", float.Parse(txt_prod_price.Text)));
                    command.Parameters.Add(new SqlParameter("@cat_name",cb_cat.Text ));
                    command.Parameters.Add(new SqlParameter("@image", img));
                    command.Parameters.Add(new SqlParameter("@prod_id", dgv_prod.CurrentRow.Cells[0].Value));
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    txt_prod_name.Clear();
                    txt_prod_price.Clear();
                    picProd.Image = Callerid_demo.Resource_picture.noimage;
                    FillDgv_prod();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }
    }
}
