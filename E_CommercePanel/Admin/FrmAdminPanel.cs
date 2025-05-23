﻿using E_CommercePanel.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_CommercePanel
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        private void btnOrders_Click_1(object sender, EventArgs e)
        {
            FrmOrders fr = new FrmOrders();
            fr.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers fr = new FrmCustomers();
            fr.Show();
            this.Hide();
        }

        private void btnEditCustomers_Click(object sender, EventArgs e)
        {
            FrmEditCustomers fr = new FrmEditCustomers();
            fr.Show();
            this.Hide();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            FrmReviews fr = new FrmReviews();
            fr.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdminLogin fr = new FrmAdminLogin();
            fr.Show();
            this.Hide();
        }
    }
}
