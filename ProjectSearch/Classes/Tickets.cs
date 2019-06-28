using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProjectSearch.Classes
{
    public class Tickets
    {
        // Declare the arrays for all the tickets 
        public  string[,] ticketOne = new string[3, 9];
        public  string[,] ticketTwo = new string[3, 9];
        public  string[,] ticketThree = new string[3, 9];
        public  string[,] ticketFour = new string[3, 9];
        public  string[,] ticketFive = new string[3, 9];
        public  string[,] ticketSix = new string[3, 9];

        //Code For Ticket 1 
        public string[] T1Row1 = new string[9];
        public string[] T1Row2 = new string[9];
        public string[] T1Row3 = new string[9];

        //Code For Ticket 2
        public string[] T2Row1 = new string[9];
        public string[] T2Row2 = new string[9];
        public string[] T2Row3 = new string[9];

        //Code For Ticket 3 
        public string[] T3Row1 = new string[9];
        public string[] T3Row2 = new string[9];
        public string[] T3Row3 = new string[9];

        //Code For Ticket 4 
        public string[] T4Row1 = new string[9];
        public string[] T4Row2 = new string[9];
        public string[] T4Row3 = new string[9];

        //Code For Ticket 5 
        public string[] T5Row1 = new string[9];
        public string[] T5Row2 = new string[9];
        public string[] T5Row3 = new string[9];

        //Code For Ticket 6 
        public string[] T6Row1 = new string[9];
        public string[] T6Row2 = new string[9];
        public string[] T6Row3 = new string[9];




        static Classes.Card getCardNum = new Classes.Card();

       
       public int rowTicket2 = 0;
        int rowTicket3 = 0;
        int rowTicket4 = 0;
        int rowTicket5 = 0;
        int rowTicket6 = 0;

        static string getExtension = getCardNum.getRandomCard();

        public static void displayTicket()
        {

        }

        public static string[][] getArray()
        {
            // For the big 2D array
            string[][] BIGarray = File.ReadAllText(@"C:\Users\student\Desktop\All Bingo Cards\" + getExtension).Split('\n')
                 .Select(r => (r.Split(' '))
                .Select(c => c).ToArray()).ToArray();


            return BIGarray;

        }

        public  string[,] getticketOne()
        {

            // for adding the specific big array indices to the specific ticket index points
            for (int i = 0; i < 3; i++)
            {
               
                for (int j = 0; j < 9; j++)
                {
                    ticketOne[i, j] = getArray()[i][j];

                    if (i == 0)
                    {
                        T1Row1[j] = getArray()[i][j];
                    }

                    else if( i == 1)
                    {
                        T1Row2[j] = getArray()[i][j];
                    }

                    else if(i == 2)
                    {
                        T1Row3[j] = getArray()[i][j];
                    }
                }

            }

            return ticketOne;


        }

        public  string[,] getticketTwo()
        {

            // for adding the specific big array indices to the specific ticket index points
            for (int i = 3; i < 6; i++) 
            {

                for (int j = 0; j < 9; j++)
                {
                    var checkit = getArray()[i][j];

                   ticketTwo[i-3, j] = checkit;

                    if (i == 3)
                    {
                        T2Row1[j] = getArray()[i][j];
                    }

                    else if (i == 4)
                    {
                        T2Row2[j] = getArray()[i][j];
                    }

                    else if (i == 5)
                    {
                        T2Row3[j] = getArray()[i][j];
                    }
                }

                rowTicket2++;

            }

            return ticketTwo;

         

        }

        public  string[,] getticketThree()
        {
            // for adding the specific big array indices to the specific ticket index points
            for (int i = 6; i < 9; i++)
            {
               
                for (int j = 0; j < 9; j++)
                {
                    ticketThree[i - 6, j] = getArray()[i][j];

                    if (i == 6)
                    {
                        T3Row1[j] = getArray()[i][j];
                    }

                    else if (i == 7)
                    {
                        T3Row2[j] = getArray()[i][j];
                    }

                    else if (i == 8)
                    {
                        T3Row3[j] = getArray()[i][j];
                    }
                }
                rowTicket3++;

            }

            return ticketThree;
        }

        public  string[,] getticketFour()
        {
            // for adding the specific big array indices to the specific ticket index points
            for (int i = 9; i < 12; i++)
            {
        
                for (int j = 0; j < 9; j++)
                {
                    ticketFour[i - 9, j] = getArray()[i][j];
                    if (i == 9)
                    {
                        T4Row1[j] = getArray()[i][j];
                    }

                    else if (i == 10)
                    {
                        T4Row2[j] = getArray()[i][j];
                    }

                    else if (i == 11)
                    {
                        T4Row3[j] = getArray()[i][j];
                    }
                }

                rowTicket4++;
            }

            return ticketFour;
        }

        public  string[,] getticketFive()
        {
            // for adding the specific big array indices to the specific ticket index points
            for (int i = 12; i < 15; i++)
            {
                
                for (int j = 0; j < 9; j++)
                {
                    ticketFive[i - 12, j] = getArray()[i][j];
                    if (i == 12)
                    {
                        T5Row1[j] = getArray()[i][j];
                    }

                    else if (i == 13)
                    {
                        T5Row2[j] = getArray()[i][j];
                    }

                    else if (i == 14)
                    {
                        T5Row3[j] = getArray()[i][j];
                    }
                }

                rowTicket5++;
            }
            return ticketFive;
        }

        public  string[,] getticketSix()
        {
            // for adding the specific big array indices to the specific ticket index points
            for (int i = 15; i < 18; i++)
            {
               
                for (int j = 0; j < 9; j++)
                {
                    ticketSix[i - 15, j] = getArray()[i][j];
                    if (i == 15)
                    {
                        T6Row1[j] = getArray()[i][j];
                    }

                    else if (i == 16)
                    {
                        T6Row2[j] = getArray()[i][j];
                    }

                    else if (i == 17)
                    {
                        T6Row3[j] = getArray()[i][j];
                    }
                }

                rowTicket6++;
            }


            return ticketSix;
        }

        public string[] getT1R1()
        {
            return T1Row1;
        }

        public string[] getT1R2()
        {
            return T1Row2;
        }

        public string[] getT1R3()
        {
            return T1Row3;
        }


        public string[] getT2R1()
        {
            return T2Row1;
        }
        public string[] getT2R2()
        {
            return T2Row2;
        }
        public string[] getT2R3()
        {
            return T2Row3;
        }

        public string[] getT3R1()
        {
            return T3Row1;
        }
        public string[] getT3R2()
        {
            return T3Row2;
        }
        public string[] getT3R3()
        {
            return T3Row3;
        }

        public string[] getT4R1()
        {
            return T4Row1;
        }
        public string[] getT4R2()
        {
            return T4Row2;
        }
        public string[] getT4R3()
        {
            return T4Row3;
        }

        public string[] getT5R1()
        {
            return T5Row1;
        }
        public string[] getT5R2()
        {
            return T5Row2;
        }
        public string[] getT5R3()
        {
            return T5Row3;
        }

        public string[] getT6R1()
        {
            return T6Row1;
        }
        public string[] getT6R2()
        {
            return T6Row2;
        }
        public string[] getT6R3()
        {
            return T6Row3;
        }

    }
}