using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_info
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_hide(object sender, MouseEventArgs e)
        {
            // Gömmer "Form2" om användaren klickar på "Cancel"-knappen.
            this.Hide();
        }

        private void Data_delete(object sender, MouseEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Databas_uppgift.accdb";
            conn.Open();

            // Tar bort de raderna där datan under rubriken ID är samma som det användaren skrivit in i textfälltet "ID_textbox". 
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "delete from Person_info where ID = " + ID_textbox.Text + "";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully deleted");
            this.Hide();
        }
    }
}
