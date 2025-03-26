using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MoneyMapper.Database
{
    public partial class DatabaseManager: Form
    {
        private MoneyMapper _moneyMapper;

        private MySqlConnection _cnn;

        public DatabaseManager(MoneyMapper moneyMapper)
        {
            InitializeComponent();
            _moneyMapper = moneyMapper;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            OpenConnection(ServerTextBox.Text, DatabaseTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text);
            Close();
        }

        public void OpenConnection(string server, string database, string username, string password)
        {
            string connStr = $"server={server};database={database};uid={username};pwd={password};";
            _cnn = new MySqlConnection(connStr);

            try
            {
                _cnn.Open();
                _moneyMapper.SetClosedConnectionButtonState(true);
                _moneyMapper.SetConnectionStatusLabelState(true);
                MessageBox.Show("Connection Success!", "Connected", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Failed to Connect", MessageBoxButtons.OK);
            }
        }

        public void CloseConnection(MySqlConnection _cnn)
        {
            if (_cnn != null && _cnn.State == ConnectionState.Open)
            {
                _cnn.Close();
                _moneyMapper.SetClosedConnectionButtonState(false);
                _moneyMapper.SetConnectionStatusLabelState(false);
                MessageBox.Show("Connection Closed.", "Disconnected from Database", MessageBoxButtons.OK);
            }
        }

        public MySqlConnection GetConnection()
        {
            return _cnn;
        }

        public bool GetConnectionStatus(MySqlConnection _cnn)
        {
            return _cnn != null && _cnn.State == ConnectionState.Open;
        }
    }
}
