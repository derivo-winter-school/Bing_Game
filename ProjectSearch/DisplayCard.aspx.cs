using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectSearch
{
    public partial class DisplayCard : System.Web.UI.Page
    {
        Classes.Tickets tickets = new Classes.Tickets();
        Classes.Randomize random = new Classes.Randomize();
        protected void Page_Load(object sender, EventArgs e)
        {

            // for printing only!
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    TextBox1.Text += tickets.getticketTwo()[i, j];

                }

            }

            // call the search

            int randomNumber = random.Random();

            string sRandomNumber = randomNumber.ToString();

            int getTick = tickets.search(sRandomNumber);

            randonum.Text = sRandomNumber;

            if(getTick == 0)
            {
                TextBox1.Text = "not found in array";
            }

            else if(getTick == 1) {

                TextBox2.Text = "found in array 1";
            }

            else if (getTick == 2)
            {

                TextBox2.Text = "found in array 2";
            }

            else if (getTick == 3)
            {

                TextBox2.Text = "found in array 3";
            }

            else if (getTick == 4)
            {

                TextBox2.Text = "found in array 4";
            }

            else if (getTick == 5)
            {

                TextBox2.Text = "found in array 5";
            }

            else if (getTick == 6)
            {

                TextBox2.Text = "found in array 6";
            }






        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}