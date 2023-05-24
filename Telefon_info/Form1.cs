using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Data_add(object sender, EventArgs e)
        {
            // Skapar en koppling mellan databasen och min kod.
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Databas_uppgift.accdb";
            conn.Open();

            // Lägger till all data från det olika fälten i min databas under rubrikerna "Namn", "Klass", "Telefonnummer", "Email" I den ordningen som det är skrivna. 
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "Insert into Person_info(Namn, Klass, Telefonnummer, Email) values ('" + Name_textbox.Text + "', '" + Class_textbox.Text + "', '" + Number_textbox.Text + "', '" + Email_textbox.Text + "')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully saved");

            // Tömmer fällten så att användaren kan skriva in ny data.
            Name_textbox.Text = "";
            Class_textbox.Text = "";
            Number_textbox.Text = "";
            Email_textbox.Text = "";


        }

        private void Data_clear(object sender, EventArgs e)
        {
            // Tömmer alla rutor när användaren klickar på "Cancel".
            Name_textbox.Text = "";
            Class_textbox.Text = "";
            Number_textbox.Text = "";
            Email_textbox.Text = "";
        }

        private void Form2_open(object sender, EventArgs e)
        {
            // Öppnar en ny form.
            Form2 frmadd = new Form2();
            frmadd.ShowDialog();
        }

        private void Data_show(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Databas_uppgift.accdb";
            conn.Open();

            // Tar all data från tabellen "Person_info" och lägger det i mitt datavisningsfällt när mitt pogram startas.
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "Select * from Person_info";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Data_grid.DataSource = dt;
            conn.Close();
        }

        private void Data_update(object sender, MouseEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Databas_uppgift.accdb";
            conn.Open();

            // Uppdaterar datan i visningsfälltet när användaren klickar på "Update"-knappen.
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "Select * from Person_info";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Data_grid.DataSource = dt;
            conn.Close();
        }
    }
}

