﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoServiceManage.Inquire
{
    public partial class FrmFood : Form
    {
        public FrmFood()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SkyComm.CloseWin(this);
        }
    }
}
