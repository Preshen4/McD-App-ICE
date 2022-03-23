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

namespace McD_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int burgers, chips, nuggets, drinks;

            burgers = Convert.ToInt32(spnBurger.Value * 35);
            chips = Convert.ToInt32(spnChips.Value * 15);
            nuggets = Convert.ToInt32(spnNuggets.Value * 18);
            drinks = Convert.ToInt32(spnDrinks.Value * 12);
            string order = "Ordered \n";
            order += spnBurger.Value + " Burgers at R" + burgers +"\n";
            order += spnChips.Value + " Chips at R" + chips  + "\n";
            order += spnNuggets.Value + " Nuggets at R" + nuggets  + "\n";
            order += spnDrinks.Value + " Burgers at R" + drinks  + "\n";
            order += "Total: R" + (burgers+chips+nuggets+drinks);

            MessageBox.Show(order);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void ConnectDB()
        { 
            string connetionString;
            connetionString = @"Data Source=VCKNDNCR4PC40\SQLEXPRESS;Initial Catalog=McDonalds;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
    }
}
