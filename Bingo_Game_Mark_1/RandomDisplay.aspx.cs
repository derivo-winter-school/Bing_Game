using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bingo_Game_Mark_1.Classes;

namespace Bingo_Game_Mark_1
{
    public partial class RandomDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        } 

        protected void display_Click(object sender, EventArgs e)
        {
            Randomize R = new Randomize();
            lbldisplay.Text = R.Random().ToString();
            txtText.Text.ToString();

            if(lbldisplay.Text == txtText.Text.ToString())
            {
                lblAnswer.Text = "You Do Not Have Bingo";
            }
            
            
       
        }

        protected void DisplayArray_Click(object sender, EventArgs e)
        {
           string[] lines = File.ReadAllLines("C:/Users/student/Desktop/Bingo_Game_Mark_1/Bingo_Game_Mark_1/TextFile/bingocard5.txt");
            TextBox1.Text = "";
            
            foreach (string line in lines)
            {
                string[] arr = line.Split(' ');
                for (int x = 0;x<9;x++)
                {
                    TextBox1.Text += arr[x]+" ";
                    
                }

                TextBox1.Text += "\n";
            }

        }
    }
}