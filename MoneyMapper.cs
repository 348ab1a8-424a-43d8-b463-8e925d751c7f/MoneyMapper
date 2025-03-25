﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMapper.Database;
using MySql.Data.MySqlClient;

namespace MoneyMapper
{
    public partial class MoneyMapper: Form
    {
        public MoneyMapper()
        {
            InitializeComponent();
            CloseConnectionButton.Enabled = false;
        }


        private void ConnectToDBButton_Click(object sender, EventArgs e)
        {
            DbConnect dbConnect = new DbConnect();
            dbConnect.ShowDialog();
        }

        private void CloseConnectionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
