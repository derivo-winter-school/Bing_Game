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
        public string[,] ticketOne = new string[3, 9];
        public string[,] ticketTwo = new string[3, 9];
        public string[,] ticketThree = new string[3, 9];
        public string[,] ticketFour = new string[3, 9];
        public string[,] ticketFive = new string[3, 9];
        public string[,] ticketSix = new string[3, 9];

        // create object of the class
        Randomize random = new Randomize();

        int rowTicket2 = 0;
        int rowTicket3 = 0;
        int rowTicket4 = 0;
        int rowTicket5 = 0;
        int rowTicket6 = 0;

        public static void displayTicket()
        {

        }

        public static string[][] getArray()
        {
            // For the big 2D array
            string[][] BIGarray = File.ReadAllText(@"C:\Users\student\Desktop\bingocardone.txt").Split('\n')
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
                    ticketTwo[rowTicket2, j] = getArray()[i][j];
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
                    ticketThree[rowTicket3, j] = getArray()[i][j];
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
                    ticketFour[rowTicket4, j] = getArray()[i][j];
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
                    ticketFive[rowTicket5, j] = getArray()[i][j];
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
                    ticketSix[rowTicket6, j] = getArray()[i][j];
                }

                rowTicket6++;
            }


            return ticketSix;
        }

        public int search(string sRandomNumber)
        {
            

            bool ifFound = false;

            int foundinArray = 0;

            while (ifFound == false)
            {

                // first ticket
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if(getticketOne()[i, j].Equals(sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 1;

                        }
                    }
                }

                // second ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (getticketTwo()[i, j]==(sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 2;
                        }
                    }
                }

                // third ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (getticketThree()[i, j]==(sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 3;
                        }
                    }
                }

                // four ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (getticketFour()[i, j]==(sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 4;
                        }
                    }
                }

                // five ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (getticketFive()[i, j]==(sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 5;
                        }
                    }
                }

                // six ticket 

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (getticketSix()[i, j]==(sRandomNumber))
                        {

                            // set bool to true
                            ifFound = true;
                            foundinArray = 6;
                        }
                    }
                }



        // while brace
            }

            return foundinArray;
            
        }




    }
}