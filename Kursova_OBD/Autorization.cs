using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Logging;

namespace Kursova_OBD
{
    public partial class Autorization : Form
    {

        private ConnectionDB dbconnection;
        private int loginAttempts = 0;
        private bool isBlocked = false;
        private DateTime blockEndTime;

        public Autorization()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            
            string enteredLogin = tb_login.Text;
            string enteredPassword = tb_password.Text;

            if (dbconnection.Connect(enteredLogin, enteredPassword))
            {
                MessageBox.Show("Підключення до бази даних встановлено успішно!", "Успіх", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                UIDB uidbForm = new UIDB();
                uidbForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Помилка підключення", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
    }
}