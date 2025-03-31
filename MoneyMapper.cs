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
using static System.Net.Mime.MediaTypeNames;

namespace MoneyMapper
{
    public partial class MoneyMapper : Form
    {
        private DatabaseManager _db;
        private Timer connectionStatusTimer;

        public MoneyMapper()
        {
            InitializeComponent();
            DisconnectToolStripMenuItem.Enabled = false;
        }
        private void MoneyMapper_Load(object sender, EventArgs e)
        {
            connectionStatusTimer = new Timer();
            connectionStatusTimer.Interval = 1000;
            connectionStatusTimer.Tick += ConnectionStatusTimer_Tick;
            connectionStatusTimer.Start();
        }

        private void ConnectionStatusTimer_Tick(object sender, EventArgs e)
        {
            if (_db != null && _db.GetConnectionStatus(_db.GetConnection()))
            {
                bool isConnected = _db.GetConnectionStatus(_db.GetConnection());
                SetConnectionStatusLabelState(isConnected);
                SetClosedConnectionButtonState(isConnected);
            }
            else
            {
                // Not connected or _db is null
            }
        }

        public void SetClosedConnectionButtonState(bool enabled)
        {
            DisconnectToolStripMenuItem.Enabled = enabled;
        }

        public void SetConnectionStatusLabelState(bool enabled)
        {
            if (enabled == true)
            {
                ConnectionStateLabel.Text = "Connected";
                ConnectionStateLabel.LinkColor = Color.Green;
            }
            else
            {
                ConnectionStateLabel.Text = "Disconnected";
                ConnectionStateLabel.LinkColor = Color.Red;
            }

        }

        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _db = new DatabaseManager(this);
            _db.ShowDialog();
        }

        private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _db.CloseConnection(_db.GetConnection());
        }
    }
}