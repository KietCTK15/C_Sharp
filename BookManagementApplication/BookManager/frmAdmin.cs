﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookManagement frmBookManagement = new frmBookManagement();
            frmBookManagement.ShowDialog();
            this.Show();
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserAccountManagement frmUserManagement = new frmUserAccountManagement();
            frmUserManagement.ShowDialog();
            this.Show();
        }
    }
}
