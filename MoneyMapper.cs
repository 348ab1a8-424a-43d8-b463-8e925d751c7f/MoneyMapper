using System;
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
    public partial class MoneyMapper : Form
    {
        private DatabaseManager _db;
        public MoneyMapper()
        {
            InitializeComponent();
            CloseConnectionButton.Enabled = false;
        }

        private void ConnectToDatabaseButton_Click(object sender, EventArgs e)
        {
            _db = new DatabaseManager(this);
            _db.ShowDialog();
        }

        private void CloseConnectionButton_Click(object sender, EventArgs e)
        {
            _db.CloseConnection(_db.GetConnection());
        }

        public void SetClosedConnectionButtonState(bool enabled)
        {
            CloseConnectionButton.Enabled = enabled;
        }
    }
}