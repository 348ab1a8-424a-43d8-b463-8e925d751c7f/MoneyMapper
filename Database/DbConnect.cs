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
    public partial class DbConnect: Form
    {
        public DbConnect()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            OpenConnection(ServerTextBox.Text, DatabaseTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text);
            Close();
        }

        public void OpenConnection(string server, string database, string username, string password)
        {
            string myConnectionString = $"server={server};database={database};uid={username};pwd={password};";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Success!", "Connected", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Failed to Connect", MessageBoxButtons.OK);
            }
        }

        public void CloseConnection()
        {

        }
    }
}
