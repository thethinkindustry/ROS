namespace Callerid_demo
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_lock = new MetroFramework.Controls.MetroButton();
            this.btn_main = new MetroFramework.Controls.MetroButton();
            this.btn_setting = new MetroFramework.Controls.MetroButton();
            this.btn_client = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.btn_analysis = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnl_main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnl_main.Controls.Add(this.panel1);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(20, 60);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1687, 880);
            this.pnl_main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.btn_lock);
            this.panel1.Controls.Add(this.btn_main);
            this.panel1.Controls.Add(this.btn_setting);
            this.panel1.Controls.Add(this.btn_client);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_analysis);
            this.panel1.Location = new System.Drawing.Point(58, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1589, 754);
            this.panel1.TabIndex = 5;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.BackgroundImage = global::Callerid_demo.Resource_picture.Hakkımızda__1_;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(1068, 484);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(335, 122);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.UseSelectable = true;
            // 
            // btn_lock
            // 
            this.btn_lock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lock.BackgroundImage = global::Callerid_demo.Resource_picture.Kilit;
            this.btn_lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lock.Location = new System.Drawing.Point(1424, 484);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(134, 122);
            this.btn_lock.TabIndex = 5;
            this.btn_lock.UseSelectable = true;
            // 
            // btn_main
            // 
            this.btn_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_main.BackgroundImage = global::Callerid_demo.Resource_picture.ROS;
            this.btn_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_main.Location = new System.Drawing.Point(550, 34);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(490, 428);
            this.btn_main.TabIndex = 0;
            this.btn_main.UseSelectable = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_setting.BackgroundImage = global::Callerid_demo.Resource_picture.İstatistikler;
            this.btn_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_setting.Location = new System.Drawing.Point(1068, 34);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(490, 204);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.UseSelectable = true;
            // 
            // btn_client
            // 
            this.btn_client.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_client.BackgroundImage = global::Callerid_demo.Resource_picture.Müşteriler;
            this.btn_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_client.Location = new System.Drawing.Point(32, 34);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(490, 204);
            this.btn_client.TabIndex = 1;
            this.btn_client.UseSelectable = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.BackgroundImage = global::Callerid_demo.Resource_picture.Çıkış;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(1068, 258);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(490, 204);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_analysis
            // 
            this.btn_analysis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_analysis.BackgroundImage = global::Callerid_demo.Resource_picture.Ayarlar__1_;
            this.btn_analysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_analysis.Location = new System.Drawing.Point(32, 258);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Size = new System.Drawing.Size(490, 204);
            this.btn_analysis.TabIndex = 2;
            this.btn_analysis.UseSelectable = true;
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1727, 960);
            this.Controls.Add(this.pnl_main);
            this.Name = "frm_main";
            this.Text = "TTI Restorant Otomasyon Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton btn_setting;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroButton btn_analysis;
        private MetroFramework.Controls.MetroButton btn_client;
        private MetroFramework.Controls.MetroButton btn_main;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btn_lock;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}