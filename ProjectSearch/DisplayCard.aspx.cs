using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectSearch
{
    public partial class DisplayCard : System.Web.UI.Page
    {
        Classes.Tickets tickets = new Classes.Tickets();

        Classes.Ball random = new Classes.Ball();

        Classes.Card card = new Classes.Card();

        public static ArrayList totalBalls = new ArrayList();


        // counters for each array
         int count1 = 0;
         int count2 = 0;
         int count3 = 0;
         int count4 = 0;
         int count5 = 0;
         int count6 = 0;


        int T1R1co = 0;
        int T1R2co = 0;
        int T1R3co = 0;

        int T2R1co = 0;
        int T2R2co = 0;
        int T2R3co = 0;

        int T3R1co = 0;
        int T3R2co = 0;
        int T3R3co = 0;

        int T4R1co = 0;
        int T4R2co = 0;
        int T4R3co = 0;

        int T5R1co = 0;
        int T5R2co = 0;
        int T5R3co = 0;

        int T6R1co = 0;
        int T6R2co = 0;
        int T6R3co = 0;


        public static int countTB = 0;

        static int controlCounter = 0;

        bool hasWon = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            

            // call the method and pass the parameters
            card.genCard(NewDataGrid, grid2, grid3, grid4, grid5, grid6);



        }

        public void checkWhichTicket()
        {
            
            // call the search

            int randomNumber = random.Random();

           ArrayList balls = random.getBallList();
           foreach( int ball in balls)
            {
                randomNumber = ball;
                string sRandomNumber = randomNumber.ToString();

                int getTick = random.search(sRandomNumber, NewDataGrid, grid2, grid3, grid4, grid5, grid6);


                randonum.Text = sRandomNumber;

                


                findWinner();

                if (getTick == 0)
                {
                    TextBox2.Text = "Not found on your card!";

                }

                else if (getTick == 1)
                {

                    TextBox2.Text = "Found in ticket 1!";

                    // increment counter
                    ++count1;
                    if (random.getT1() == 0)
                    {
                        ++T1R1co;
                    }
                    else if (random.getT1() == 1)
                    {
                        ++T1R2co;
                    }
                    else if (random.getT1() == 2)
                    {
                        ++T1R3co;
                    }

                }

                else if (getTick == 2)
                {

                    TextBox2.Text = "Found in ticket 2!";

                    // increment counter
                    ++count2;
                    if (random.getT2() == 3)
                    {
                        ++T2R1co;
                    }
                    else if (random.getT2() == 4)
                    {
                        ++T2R2co;
                    }
                    else if (random.getT2() == 5)
                    {
                        ++T2R3co;
                    }
                }

                else if (getTick == 3)
                {

                    TextBox2.Text = "Found in ticket 3!";

                    // increment counter
                    ++count3;

                    if (random.getT3() == 6)
                    {
                        ++T3R1co;
                    }
                    else if (random.getT3() == 7)
                    {
                        ++T3R2co;
                    }
                    else if (random.getT3() == 8)
                    {
                        ++T3R3co;
                    }
                }

                else if (getTick == 4)
                {

                    TextBox2.Text = "Found in ticket 4!";

                    // increment counter
                    ++count4;
                    if (random.getT4() == 9)
                    {
                        ++T4R1co;
                    }
                    else if (random.getT4() == 10)
                    {
                        ++T4R2co;
                    }
                    else if (random.getT4() == 11)
                    {
                        ++T4R3co;
                    }
                }

                else if (getTick == 5)
                {

                    TextBox2.Text = "Found in ticket 5!";

                    // increment counter
                    ++count5;

                    if (random.getT5() == 12)
                    {
                        ++T5R1co;
                    }
                    else if (random.getT5() == 13)
                    {
                        ++T5R2co;
                    }
                    else if (random.getT5() == 14)
                    {
                        ++T5R3co;
                    }
                }

                else if (getTick == 6)
                {

                    TextBox2.Text = "Found in ticket 6!";

                    // increment counter
                    ++count6;

                    if (random.getT6() == 15)
                    {
                        ++T6R1co;
                    }
                    else if (random.getT5() == 16)
                    {
                        ++T6R2co;
                    }
                    else if (random.getT5() == 17)
                    {
                        ++T6R3co;
                    }
                }

                TextBox4.Text = "Ticket 1: " + count1.ToString();
                TextBox5.Text = "Ticket 2: " + count2.ToString();
                TextBox6.Text = "Ticket 3: " + count3.ToString();
                TextBox7.Text = "Ticket 4: " + count4.ToString();
                TextBox8.Text = "Ticket 5: " + count5.ToString();
                TextBox9.Text = "Ticket 6: " + count6.ToString();
            }

            



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void findWinner()
        {
            // to check the counter if it reaches 15 in 1 ticket

            // get the number of balls 
            totalBalls = random.getBallList();

            TextBox3.Text = totalBalls.Count.ToString();

            var arrayholder = new StringBuilder();

            int index =  0;
            //foreach (var item in totalBalls)
            //{

            //    TextBox3.Text += (item.ToString() + " " );
            //}
            if (index == 0)
            {
                if (count1 == 15)
                {
                    TextBox10.Text = "You have won! Your winning ticket is ticket number 1!";
                    hasWon = true;
                }

                else if (count2 == 15)
                {
                    TextBox10.Text = "You have won! Your winning ticket is ticket number 2!";
                    hasWon = true;
                }

                else if (count3 == 15)
                {
                    TextBox10.Text = "You have won! Your winning ticket is ticket number 3!";
                    hasWon = true;
                }

                else if (count4 == 15)
                {
                    TextBox10.Text = "You have won! Your winning ticket is ticket number 4!";
                    hasWon = true;
                }

                else if (count5 == 15)
                {
                    TextBox10.Text = "You have won! Your winning ticket is ticket number 5!";
                    hasWon = true;
                }

                else if (count6 == 15)
                {
                    TextBox10.Text = "You have won! Your winning ticket is ticket number 6!";
                    hasWon = true;
                }

                else if (totalBalls.Count == 90// && //(
                                               // count1 != 15
                                               //|| count2 != 15
                                               //|| count3 1= 15
                                               //|| count4 != 15
                                               //|| count5 != 15
                                               //|| count6 != 15
                    )//)
                {

                    TextBox10.Text = "You lose!";
                    hasWon = false;

                }
            }
             else if (index == 1)
            {
                if (T1R1co == 9|| T1R2co == 9 || T1R3co == 9)
                {
                    TextBox11.Text = "You have won! Your winning ticket is ticket number 1!";
                }
                else if (T2R1co == 9 || T2R2co == 9 || T2R3co == 9)
                {
                    TextBox11.Text = "You have won! Your winning ticket is ticket number 2!";
                }
                else if (T3R1co == 9 || T3R2co == 9 || T3R3co == 9)
                {
                    TextBox11.Text = "You have won! Your winning ticket is ticket number 3!";
                }
                else if (T4R1co == 9 || T4R2co == 9 || T4R3co == 9)
                {
                    TextBox11.Text = "You have won! Your winning ticket is ticket number 4!";
                }
                else if (T5R1co == 9 || T5R2co == 9 || T5R3co == 9)
                {
                    TextBox11.Text = "You have won! Your winning ticket is ticket number 5!";
                }
                else if (T6R1co == 9 || T6R2co == 9 || T6R3co == 9)
                {
                    TextBox11.Text = "You have won! Your winning ticket is ticket number 6!";
                }

            }


        }

        protected void nextBtn_Click(object sender, EventArgs e)
        {
           
            if (controlCounter <= 90)
            {
                nextBtn.Enabled = false; //Disable Button
                checkWhichTicket();
                nextBtn.Text = "Next Number";

                controlCounter++;
                
            }
            nextBtn.Enabled = true; // Enable Button
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}