using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Aplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;

        private SQLiteCommand sql_cmd;

        private SQLiteDataAdapter DB;

        private DataSet DS = new DataSet();

        private DataTable DT = new DataTable();

        private void label1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=DataBase.db;Version=3;New=False;Compress=True;");
        }

       

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            
            sql_con.Close();
        }

        
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Users";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        //add
        private void button1_Click_1(object sender, EventArgs e)
        {
            string txtQuery = "insert into Users (ID_User,Name)values('"+textBox1.Text+"','"+textBox2.Text+"')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        //edit
        private void button2_Click_1(object sender, EventArgs e)
        {
            string txtQuery = "update Users set Name='" + textBox2.Text + "' where ID_User='" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        //delete
        private void button3_Click_1(object sender, EventArgs e)
        {
            string txtQuery = "delete from Users where ID_User='" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}