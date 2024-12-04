using DevExpress.XtraBars;
using MarketDatabase.Entities.Concreate;
using MarketDatabase.FormUI.Displays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarketDatabase.FormUI
{
    public partial class HomePagee : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public HomePagee()
        {
            InitializeComponent();
            
        }
        Form anaForm = new Form1();
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();


        }
        private SaleDisplay form;

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
           
                form = new SaleDisplay();
                
                form.Show();
           





        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Global.sessions = false;

        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {
            ReportPage rpt = new ReportPage();
            rpt.Show();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            kasa cd = new kasa();
            cd.Show();
        }
    }
}
