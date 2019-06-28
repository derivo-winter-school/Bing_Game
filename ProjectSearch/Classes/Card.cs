using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProjectSearch.Classes
{
    public class Card
    {

        // create an object of the class
        static Classes.Tickets ticketArray = new Classes.Tickets();

        // Declare the arrays for all the tickets 
        static public string[,] ticketOne = new string[3, 9];
        static public string[,] ticketTwo = new string[3, 9];
        static public string[,] ticketThree = new string[3, 9];
        static public string[,] ticketFour = new string[3, 9];
        static public string[,] ticketFive = new string[3, 9];
        static public string[,] ticketSix = new string[3, 9];






        public void genCard(GridView NewDataGrid, GridView grid2, GridView grid3, GridView grid4, GridView grid5, GridView grid6)
        {

            // arrays to hold the specific data

            // arrays to hold data from other class
            ticketOne = ticketArray.getticketOne();
            ticketTwo = ticketArray.getticketTwo();
            ticketThree = ticketArray.getticketThree();
            ticketFour = ticketArray.getticketFour();
            ticketFive = ticketArray.getticketFive();
            ticketSix = ticketArray.getticketSix();

            // datatable object
            // dt 1
            DataTable dt = new DataTable("BingoCard");

            // dt 2
            DataTable dt2 = new DataTable("BingoCard2");

            // dt 3
            DataTable dt3 = new DataTable("BingoCard3");

            // dt 4
            DataTable dt4 = new DataTable("BingoCard4");

            // dt 5
            DataTable dt5 = new DataTable("BingoCard5");

            // dt 1
            DataTable dt6 = new DataTable("BingoCard6");

            // DataColumn for the tables to show specfic data within specific array;
            DataColumn dc1 = new DataColumn("col1");
            DataColumn dc2 = new DataColumn("col2");
            DataColumn dc3 = new DataColumn("col3");
            DataColumn dc4 = new DataColumn("col4");
            DataColumn dc5 = new DataColumn("col5");
            DataColumn dc6 = new DataColumn("col6");
            DataColumn dc7 = new DataColumn("col7");
            DataColumn dc8 = new DataColumn("col8");
            DataColumn dc9 = new DataColumn("col9");

            // DataColumn for the tables to show specfic data within specific array;
            DataColumn dcA1 = new DataColumn("col1");
            DataColumn dcA2 = new DataColumn("col2");
            DataColumn dcA3 = new DataColumn("col3");
            DataColumn dcA4 = new DataColumn("col4");
            DataColumn dcA5 = new DataColumn("col5");
            DataColumn dcA6 = new DataColumn("col6");
            DataColumn dcA7 = new DataColumn("col7");
            DataColumn dcA8 = new DataColumn("col8");
            DataColumn dcA9 = new DataColumn("col9");


            // DataColumn for the tables to show specfic data within specific array;
            DataColumn dcB1 = new DataColumn("col1");
            DataColumn dcB2 = new DataColumn("col2");
            DataColumn dcB3 = new DataColumn("col3");
            DataColumn dcB4 = new DataColumn("col4");
            DataColumn dcB5 = new DataColumn("col5");
            DataColumn dcB6 = new DataColumn("col6");
            DataColumn dcB7 = new DataColumn("col7");
            DataColumn dcB8 = new DataColumn("col8");
            DataColumn dcB9 = new DataColumn("col9");

            // DataColumn for the tables to show specfic data within specific array;
            DataColumn dcC1 = new DataColumn("col1");
            DataColumn dcC2 = new DataColumn("col2");
            DataColumn dcC3 = new DataColumn("col3");
            DataColumn dcC4 = new DataColumn("col4");
            DataColumn dcC5 = new DataColumn("col5");
            DataColumn dcC6 = new DataColumn("col6");
            DataColumn dcC7 = new DataColumn("col7");
            DataColumn dcC8 = new DataColumn("col8");
            DataColumn dcC9 = new DataColumn("col9");

            // DataColumn for the tables to show specfic data within specific array;
            DataColumn dcD1 = new DataColumn("col1");
            DataColumn dcD2 = new DataColumn("col2");
            DataColumn dcD3 = new DataColumn("col3");
            DataColumn dcD4 = new DataColumn("col4");
            DataColumn dcD5 = new DataColumn("col5");
            DataColumn dcD6 = new DataColumn("col6");
            DataColumn dcD7 = new DataColumn("col7");
            DataColumn dcD8 = new DataColumn("col8");
            DataColumn dcD9 = new DataColumn("col9");

            // DataColumn for the tables to show specfic data within specific array;
            DataColumn dcE1 = new DataColumn("col1");
            DataColumn dcE2 = new DataColumn("col2");
            DataColumn dcE3 = new DataColumn("col3");
            DataColumn dcE4 = new DataColumn("col4");
            DataColumn dcE5 = new DataColumn("col5");
            DataColumn dcE6 = new DataColumn("col6");
            DataColumn dcE7 = new DataColumn("col7");
            DataColumn dcE8 = new DataColumn("col8");
            DataColumn dcE9 = new DataColumn("col9");

            // add the columns to the datatable
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            dt.Columns.Add(dc8);
            dt.Columns.Add(dc9);

            // add the columns to the datatable
            dt2.Columns.Add(dcA1);
            dt2.Columns.Add(dcA2);
            dt2.Columns.Add(dcA3);
            dt2.Columns.Add(dcA4);
            dt2.Columns.Add(dcA5);
            dt2.Columns.Add(dcA6);
            dt2.Columns.Add(dcA7);
            dt2.Columns.Add(dcA8);
            dt2.Columns.Add(dcA9);

            // add the columns to the datatable
            dt3.Columns.Add(dcB1);
            dt3.Columns.Add(dcB2);
            dt3.Columns.Add(dcB3);
            dt3.Columns.Add(dcB4);
            dt3.Columns.Add(dcB5);
            dt3.Columns.Add(dcB6);
            dt3.Columns.Add(dcB7);
            dt3.Columns.Add(dcB8);
            dt3.Columns.Add(dcB9);

            // add the columns to the datatable
            dt4.Columns.Add(dcC1);
            dt4.Columns.Add(dcC2);
            dt4.Columns.Add(dcC3);
            dt4.Columns.Add(dcC4);
            dt4.Columns.Add(dcC5);
            dt4.Columns.Add(dcC6);
            dt4.Columns.Add(dcC7);
            dt4.Columns.Add(dcC8);
            dt4.Columns.Add(dcC9);

            // add the columns to the datatable
            dt5.Columns.Add(dcD1);
            dt5.Columns.Add(dcD2);
            dt5.Columns.Add(dcD3);
            dt5.Columns.Add(dcD4);
            dt5.Columns.Add(dcD5);
            dt5.Columns.Add(dcD6);
            dt5.Columns.Add(dcD7);
            dt5.Columns.Add(dcD8);
            dt5.Columns.Add(dcD9);

            // add the columns to the datatable
            dt6.Columns.Add(dcE1);
            dt6.Columns.Add(dcE2);
            dt6.Columns.Add(dcE3);
            dt6.Columns.Add(dcE4);
            dt6.Columns.Add(dcE5);
            dt6.Columns.Add(dcE6);
            dt6.Columns.Add(dcE7);
            dt6.Columns.Add(dcE8);
            dt6.Columns.Add(dcE9);



            // for loop to iterate through array to add items to datatable for rows
            for (int i = 0; i < 3; i++)
            {
                DataRow dr = dt.NewRow();
                DataRow dr2 = dt2.NewRow();
                DataRow dr3 = dt3.NewRow();
                DataRow dr4 = dt4.NewRow();
                DataRow dr5 = dt5.NewRow();
                DataRow dr6 = dt6.NewRow();



                for (int j = 0; j < 9; j++)
                {

                    dr["col" + (j + 1).ToString()] = ticketOne[i, j];

                    dr2["col" + (j + 1).ToString()] = ticketTwo[i, j];

                    dr3["col" + (j + 1).ToString()] = ticketThree[i, j];

                    dr4["col" + (j + 1).ToString()] = ticketFour[i, j];

                    dr5["col" + (j + 1).ToString()] = ticketFive[i, j];

                    dr6["col" + (j + 1).ToString()] = ticketSix[i, j];
                }

                dt.Rows.Add(dr);
                dt2.Rows.Add(dr2);
                dt3.Rows.Add(dr3);
                dt4.Rows.Add(dr4);
                dt5.Rows.Add(dr5);
                dt6.Rows.Add(dr6);


            }


            // add grid views for each table 
            NewDataGrid.DataSource = dt;
            NewDataGrid.DataBind();


            grid2.DataSource = dt2;
            grid2.DataBind();

            grid3.DataSource = dt3;
            grid3.DataBind();

            grid4.DataSource = dt4;
            grid4.DataBind();

            grid5.DataSource = dt5;
            grid5.DataBind();

            grid6.DataSource = dt6;
            grid6.DataBind();


        }

        public string getRandomCard()
        {
            Random R = new Random();
            int randomCard = R.Next(1, 6);

            string randomTXT;

            switch (randomCard)
            {
                case 1:
                    randomTXT = "bingocardone.txt";
                    break;
                case 2:
                    randomTXT = "bingocardtwo.txt";
                    break;

                case 3:
                    randomTXT = "bingocardthree.txt";
                    break;

                case 4:
                    randomTXT = "bingocardfour.txt";
                    break;

                case 5:
                    randomTXT = "bingocardfive.txt";
                    break;

                case 6:
                    randomTXT = "bingocardsix.txt";
                    break;

                default:
                    randomTXT = "bingocardone.txt";
                    break;


            }

            return randomTXT;


        }

    }
}