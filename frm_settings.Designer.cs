namespace Callerid_demo
{
    partial class frm_settings
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txt_table = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addtable = new MetroFramework.Controls.MetroButton();
            this.btn_deltable = new MetroFramework.Controls.MetroButton();
            this.dgv_tables = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_cat = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_cat_dell = new MetroFramework.Controls.MetroButton();
            this.btn_prod_dell = new MetroFramework.Controls.MetroButton();
            this.btn_cat_add = new MetroFramework.Controls.MetroButton();
            this.btn_prod_add = new MetroFramework.Controls.MetroButton();
            this.btn_prod_update = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_prod_price = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_prod_name = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.btn_browse = new MetroFramework.Controls.MetroButton();
            this.picProd = new System.Windows.Forms.PictureBox();
            this.dgv_prod = new System.Windows.Forms.DataGridView();
            this.dgv_cat = new System.Windows.Forms.DataGridView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tables)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(300, 70);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1667, 810);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 74);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1659, 732);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Ana Menü";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTabPage1.BackgroundImage = global::Callerid_demo.Resource_picture.gray;
            this.metroTabPage1.Controls.Add(this.txt_table);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.btn_addtable);
            this.metroTabPage1.Controls.Add(this.btn_deltable);
            this.metroTabPage1.Controls.Add(this.dgv_tables);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 74);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1659, 732);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Masalar";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txt_table
            // 
            this.txt_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_table.Location = new System.Drawing.Point(998, 103);
            this.txt_table.Name = "txt_table";
            this.txt_table.Size = new System.Drawing.Size(184, 53);
            this.txt_table.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(672, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Masa Numarası :";
            // 
            // btn_addtable
            // 
            this.btn_addtable.BackgroundImage = global::Callerid_demo.Resource_picture.Masa_Ekle;
            this.btn_addtable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addtable.Location = new System.Drawing.Point(692, 249);
            this.btn_addtable.Name = "btn_addtable";
            this.btn_addtable.Size = new System.Drawing.Size(490, 204);
            this.btn_addtable.TabIndex = 6;
            this.btn_addtable.UseSelectable = true;
            this.btn_addtable.Click += new System.EventHandler(this.btn_addtable_Click);
            // 
            // btn_deltable
            // 
            this.btn_deltable.BackgroundImage = global::Callerid_demo.Resource_picture.Masa_Sil;
            this.btn_deltable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deltable.Location = new System.Drawing.Point(692, 474);
            this.btn_deltable.Name = "btn_deltable";
            this.btn_deltable.Size = new System.Drawing.Size(490, 204);
            this.btn_deltable.TabIndex = 5;
            this.btn_deltable.UseSelectable = true;
            this.btn_deltable.Click += new System.EventHandler(this.btn_deltable_Click);
            // 
            // dgv_tables
            // 
            this.dgv_tables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_tables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tables.Location = new System.Drawing.Point(23, 25);
            this.dgv_tables.Name = "dgv_tables";
            this.dgv_tables.RowTemplate.Height = 24;
            this.dgv_tables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tables.Size = new System.Drawing.Size(617, 661);
            this.dgv_tables.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackgroundImage = global::Callerid_demo.Resource_picture.gray;
            this.metroTabPage2.Controls.Add(this.groupBox2);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.btn_cat_dell);
            this.metroTabPage2.Controls.Add(this.btn_prod_dell);
            this.metroTabPage2.Controls.Add(this.btn_cat_add);
            this.metroTabPage2.Controls.Add(this.btn_prod_add);
            this.metroTabPage2.Controls.Add(this.btn_prod_update);
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.dgv_prod);
            this.metroTabPage2.Controls.Add(this.dgv_cat);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 74);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1659, 732);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Ürünler";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.txt_cat);
            this.groupBox2.Location = new System.Drawing.Point(930, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 67);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Ekle";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroLabel7.Location = new System.Drawing.Point(12, 23);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 20);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Katagori Adı";
            // 
            // txt_cat
            // 
            this.txt_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cat.Location = new System.Drawing.Point(156, 13);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.Size = new System.Drawing.Size(449, 45);
            this.txt_cat.TabIndex = 16;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroLabel2.Location = new System.Drawing.Point(390, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 20);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Ürünler";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 20);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Katagoriler";
            // 
            // btn_cat_dell
            // 
            this.btn_cat_dell.BackgroundImage = global::Callerid_demo.Resource_picture.Kategori_Sil;
            this.btn_cat_dell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cat_dell.Location = new System.Drawing.Point(1279, 611);
            this.btn_cat_dell.Name = "btn_cat_dell";
            this.btn_cat_dell.Size = new System.Drawing.Size(323, 115);
            this.btn_cat_dell.TabIndex = 11;
            this.btn_cat_dell.UseSelectable = true;
            this.btn_cat_dell.Click += new System.EventHandler(this.btn_cat_dell_Click);
            // 
            // btn_prod_dell
            // 
            this.btn_prod_dell.BackgroundImage = global::Callerid_demo.Resource_picture.Ürün_Sil;
            this.btn_prod_dell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prod_dell.Location = new System.Drawing.Point(950, 611);
            this.btn_prod_dell.Name = "btn_prod_dell";
            this.btn_prod_dell.Size = new System.Drawing.Size(323, 115);
            this.btn_prod_dell.TabIndex = 10;
            this.btn_prod_dell.UseSelectable = true;
            this.btn_prod_dell.Click += new System.EventHandler(this.btn_prod_dell_Click);
            // 
            // btn_cat_add
            // 
            this.btn_cat_add.BackgroundImage = global::Callerid_demo.Resource_picture.Kategori_Ekle;
            this.btn_cat_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cat_add.Location = new System.Drawing.Point(1279, 490);
            this.btn_cat_add.Name = "btn_cat_add";
            this.btn_cat_add.Size = new System.Drawing.Size(323, 115);
            this.btn_cat_add.TabIndex = 9;
            this.btn_cat_add.UseSelectable = true;
            this.btn_cat_add.Click += new System.EventHandler(this.btn_cat_add_Click);
            // 
            // btn_prod_add
            // 
            this.btn_prod_add.BackgroundImage = global::Callerid_demo.Resource_picture.Ürün_Ekle;
            this.btn_prod_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prod_add.Location = new System.Drawing.Point(950, 490);
            this.btn_prod_add.Name = "btn_prod_add";
            this.btn_prod_add.Size = new System.Drawing.Size(323, 115);
            this.btn_prod_add.TabIndex = 8;
            this.btn_prod_add.UseSelectable = true;
            this.btn_prod_add.Click += new System.EventHandler(this.btn_prod_add_Click);
            // 
            // btn_prod_update
            // 
            this.btn_prod_update.BackgroundImage = global::Callerid_demo.Resource_picture.Ürün_Güncelle;
            this.btn_prod_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prod_update.Location = new System.Drawing.Point(950, 369);
            this.btn_prod_update.Name = "btn_prod_update";
            this.btn_prod_update.Size = new System.Drawing.Size(652, 115);
            this.btn_prod_update.TabIndex = 7;
            this.btn_prod_update.UseSelectable = true;
            this.btn_prod_update.Click += new System.EventHandler(this.btn_prod_update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txt_prod_price);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txt_prod_name);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cb_cat);
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Controls.Add(this.picProd);
            this.groupBox1.Location = new System.Drawing.Point(930, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroLabel5.Location = new System.Drawing.Point(20, 166);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 20);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Fiyat";
            // 
            // txt_prod_price
            // 
            this.txt_prod_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_prod_price.Location = new System.Drawing.Point(20, 189);
            this.txt_prod_price.Name = "txt_prod_price";
            this.txt_prod_price.Size = new System.Drawing.Size(441, 45);
            this.txt_prod_price.TabIndex = 18;
            this.txt_prod_price.TextChanged += new System.EventHandler(this.txt_prod_price_TextChanged);
            this.txt_prod_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroLabel4.Location = new System.Drawing.Point(20, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 20);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Ürün Adı";
            // 
            // txt_prod_name
            // 
            this.txt_prod_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_prod_name.Location = new System.Drawing.Point(20, 116);
            this.txt_prod_name.Name = "txt_prod_name";
            this.txt_prod_name.Size = new System.Drawing.Size(441, 45);
            this.txt_prod_name.TabIndex = 16;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 21);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 20);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Katagoriler";
            // 
            // cb_cat
            // 
            this.cb_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(20, 44);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(441, 46);
            this.cb_cat.TabIndex = 15;
            this.cb_cat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.BackgroundImage = global::Callerid_demo.Resource_picture.Resim_Ekle;
            this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_browse.Location = new System.Drawing.Point(481, 189);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(197, 60);
            this.btn_browse.TabIndex = 14;
            this.btn_browse.UseSelectable = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // picProd
            // 
            this.picProd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picProd.Image = global::Callerid_demo.Resource_picture.noimage;
            this.picProd.Location = new System.Drawing.Point(481, 10);
            this.picProd.Name = "picProd";
            this.picProd.Size = new System.Drawing.Size(203, 176);
            this.picProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProd.TabIndex = 5;
            this.picProd.TabStop = false;
            // 
            // dgv_prod
            // 
            this.dgv_prod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_prod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod.Location = new System.Drawing.Point(390, 52);
            this.dgv_prod.Name = "dgv_prod";
            this.dgv_prod.RowTemplate.Height = 24;
            this.dgv_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_prod.Size = new System.Drawing.Size(472, 630);
            this.dgv_prod.TabIndex = 4;
            this.dgv_prod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dgv_prod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_prod_MouseClick);
            // 
            // dgv_cat
            // 
            this.dgv_cat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cat.Location = new System.Drawing.Point(27, 52);
            this.dgv_cat.Name = "dgv_cat";
            this.dgv_cat.RowTemplate.Height = 24;
            this.dgv_cat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cat.Size = new System.Drawing.Size(311, 630);
            this.dgv_cat.TabIndex = 3;
            this.dgv_cat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cat_CellClick);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackgroundImage = global::Callerid_demo.Resource_picture.gray;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 74);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1659, 732);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Kişiler";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 890);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frm_settings";
            this.Text = "Ayarlar";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_settings_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tables)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.DataGridView dgv_tables;
        private MetroFramework.Controls.MetroButton btn_addtable;
        private MetroFramework.Controls.MetroButton btn_deltable;
        private System.Windows.Forms.DataGridView dgv_prod;
        private System.Windows.Forms.DataGridView dgv_cat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picProd;
        private MetroFramework.Controls.MetroButton btn_cat_dell;
        private MetroFramework.Controls.MetroButton btn_prod_dell;
        private MetroFramework.Controls.MetroButton btn_cat_add;
        private MetroFramework.Controls.MetroButton btn_prod_add;
        private MetroFramework.Controls.MetroButton btn_prod_update;
        private System.Windows.Forms.TextBox txt_table;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_browse;
        private System.Windows.Forms.ComboBox cb_cat;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txt_prod_price;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txt_prod_name;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txt_cat;
    }
}