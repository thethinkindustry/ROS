using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Components;

namespace Callerid_demo
{
    public partial class frm_main : MetroForm
    {
       

        public frm_main()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
         }

       

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            frm_proc Frm_proc= new frm_proc();
            FrmShow(Frm_proc);
          
        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {
            frm_settings Frm_settings = new frm_settings();
            FrmShow(Frm_settings);
        }
        void FrmShow(Form frm)
        {
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

    }
}
