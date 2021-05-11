using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TODOLIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-NVG7K5K\\SQLEXPRESS;Initial Catalog=To Do List;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Table]([Entry Number],Activity,Date) VALUES (@EntryNumber,@Activity,@Date)", con);
            cmd.Parameters.AddWithValue("@EntryNumber", int.Parse(txtEnt.Text));
            cmd.Parameters.AddWithValue("@Activity", txtAct.Text);
            cmd.Parameters.AddWithValue("@Date", txtDate.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM [Table]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            txtEnt.Text = "";
            txtAct.Text = "";
            txtDate.Text = "";
           
            
            MessageBox.Show("Added");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-NVG7K5K\\SQLEXPRESS;Initial Catalog=To Do List;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE [Table] SET Activity=@Activity,Date=@Date WHERE [Entry Number]=@EntryNumber", con);
            cmd.Parameters.AddWithValue("@EntryNumber", int.Parse(txtEnt.Text));
            cmd.Parameters.AddWithValue("@Activity", txtAct.Text);
            cmd.Parameters.AddWithValue("@Date", txtDate.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM [Table]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            txtEnt.Text = "";
            txtAct.Text = "";
            txtDate.Text = "";


            MessageBox.Show("Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-NVG7K5K\\SQLEXPRESS;Initial Catalog=To Do List;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE [Table] WHERE [Entry Number]=@EntryNumber", con);
            cmd.Parameters.AddWithValue("@EntryNumber", int.Parse(txtEnt.Text));
            cmd.Parameters.AddWithValue("@Activity", txtAct.Text);
            cmd.Parameters.AddWithValue("@Date", txtDate.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM [Table]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            txtEnt.Text = "";
            txtAct.Text = "";
            txtDate.Text = "";


            MessageBox.Show("Deleted");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-NVG7K5K\\SQLEXPRESS;Initial Catalog=To Do List;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-NVG7K5K\\SQLEXPRESS;Initial Catalog=To Do List;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Table] WHERE [Entry Number]=@EntryNumber", con);
            cmd.Parameters.AddWithValue("EntryNumber",int.Parse(txtEnt.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
