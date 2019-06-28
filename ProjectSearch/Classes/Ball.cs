using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProjectSearch.Classes
{
    public class Ball
    {
        // create object
        Tickets tick = new Tickets();

        int countBalls = 0;

        // Declare the arrays for all the tickets 
        public string[,] ticketOneA = new string[3, 9];
        public string[,] ticketTwoA = new string[3, 9];
        public string[,] ticketThreeA = new string[3, 9];
        public string[,] ticketFourA = new string[3, 9];
        public string[,] ticketFiveA = new string[3, 9];
        public string[,] ticketSixA = new string[3, 9];

        // array to hold the balls

        public static ArrayList ballList = new ArrayList();


        int T1R1 = 0;
        

        int T2R1 = 0;
       

        int T3R1 = 0;
      

        int T4R1 = 0;
        

        int T5R1 = 0;
     

        int T6R1 = 0;
      


        public int Random()
        {
            Random R = new Random();
            int num = R.Next(1, 91);
            Boolean flag = true;
            while (flag)
            {
                if (ballList.Contains(num))
                {
                    num = R.Next(1, 91);
                }
                else
                {
                    flag = false;
                }
            }
            ballList.Add(num);
           


            return num;
        }

        public ArrayList getBallList()
        {
            return ballList;
        }

        public int getNumberBalls()
        {
            return ballList.Count;
        }



        public int search(string sRandomNumber, GridView NewDataGrid, GridView grid2, GridView grid3, GridView grid4, GridView grid5, GridView grid6 )
        {
            ticketOneA = tick.getticketOne();
            ticketTwoA = tick.getticketTwo();
            ticketThreeA = tick.getticketThree();
            ticketFourA = tick.getticketFour();
            ticketFiveA = tick.getticketFive();
            ticketSixA = tick.getticketSix();

            bool ifFound = false;

            int foundinArray = 0;

         //   while (ifFound == false)
         //   {

                // first ticket
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (ticketOneA[i, j] == (sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 1;
                        T1R1 = i;
                            NewDataGrid.Rows[i].Cells[j].BackColor = System.Drawing.Color.Red;


                        }
                    }
                }

                // second ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (ticketTwoA[i, j] == (sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 2;
                        T2R1 = i+3;
                            grid2.Rows[i].Cells[j].BackColor = System.Drawing.Color.Red;
                        }
                    }
                }

                // third ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (ticketThreeA[i, j] == (sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 3;
                        T3R1 = i+6;
                        grid3.Rows[i].Cells[j].BackColor = System.Drawing.Color.Red;
                        }
                    }
                }

                // four ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (ticketFourA[i, j] == (sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 4;
                        T4R1 = i+9;
                        grid4.Rows[i].Cells[j].BackColor = System.Drawing.Color.Red;
                        }
                    }
                }

                // five ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (ticketFiveA[i, j] == (sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 5;
                        T5R1 = i+12;
                        grid5.Rows[i].Cells[j].BackColor = System.Drawing.Color.Red;
                        }
                    }
                }

                // six ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (ticketSixA[i, j] == (sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 6;
                        T6R1 = i+15;
                        grid6.Rows[i].Cells[j].BackColor = System.Drawing.Color.Red;
                        }
                    }
                }



                // while brace
            //}

            return foundinArray;

        }
        public int getT1()
        {
            return T1R1;
        }

        public int getT2()
        {
            return T2R1;
        }

        public int getT3()
        {
            return T3R1;
        }

        public int getT4()
        {
            return T4R1;
        }

        public int getT5()
        {
            return T5R1;
        }

        public int getT6()
        {
            return T6R1;
        }


    }
}