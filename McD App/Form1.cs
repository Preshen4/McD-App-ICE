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
            int total;
            burgers = Convert.ToInt32(spnBurger.Value * 35);
            chips = Convert.ToInt32(spnChips.Value * 15);
            nuggets = Convert.ToInt32(spnNuggets.Value * 18);
            drinks = Convert.ToInt32(spnDrinks.Value * 12);
            total = (burgers + chips + nuggets + drinks);
            string order = "Ordered \n";
            order += spnBurger.Value + " Burgers at R" + burgers +"\n";
            order += spnChips.Value + " Chips at R" + chips  + "\n";
            order += spnNuggets.Value + " Nuggets at R" + nuggets  + "\n";
            order += spnDrinks.Value + " Burgers at R" + drinks  + "\n";
            order += "Total: R" + total;

            MessageBox.Show(order);
            try
            {
                string query = "Insert Into Orders Values (@burgers,@chips,@nuggets,@cokes,@totalPrice)";
                string connetionString = @"Data Source=ML-RefVm-631348\SQLEXPRESS;Initial Catalog=McDonalds;Integrated Security=True";
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con)) 
                {
                    cmd.Parameters.Add("@burgers", SqlDbType.Int).Value = spnBurger.Value.ToString();
                    cmd.Parameters.Add("@chips", SqlDbType.Int).Value = spnChips.Value.ToString();
                    cmd.Parameters.Add("@nuggets", SqlDbType.Int).Value = spnNuggets.Value.ToString();
                    cmd.Parameters.Add("@cokes", SqlDbType.Int).Value = spnDrinks.Value.ToString();
                    cmd.Parameters.Add("@totalPrice", SqlDbType.Float).Value = total;

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = @"Data Source=ML-RefVm-631348\SQLEXPRESS;Initial Catalog=McDonalds;Integrated Security=True";

                string query = "Select * From Orders";

                SqlConnection con = new SqlConnection(connetionString);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Order ID: " + reader.GetInt32(0)
                            + "\nNumber of Burgers: " + reader.GetInt32(1)
                            + "\nNumber of Chips: " + reader.GetInt32(2)
                            + "\nNumber of Drinks: " + reader.GetInt32(3)
                            + "\nNumber of Nuggets: " + reader.GetInt32(4)
                            + "\nTotal Price: " + reader.GetDouble(5));
                    }
                }


            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }

        }

    }
}
