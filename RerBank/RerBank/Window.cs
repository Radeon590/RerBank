using System;
using System.Collections.Generic;

namespace RerBank
{
    class Window
    {

        //Values
        private int page;
        private int strings;
        //

        //Constructor
        public Window(int page,int strings)
        {
            this.page = page;
            this.strings = strings;
        }
        //

        //Window
        public void window()
        {
            List<string> names = new List<string>();
            //Strings
            string[] S1 = new string[12];
            S1[0] = "Menu";
            S1[1] = "Scores";
            S1[2] = "Sisn in";
            S1[3] = "Sign up";
            S1[4] = "Skip day?";
            S1[5] = "Close?";
            S1[6] = "Exit?";
            S1[7] = "Froze?";
            S1[8] = "Transfer to:";
            S1[9] = "Unfroze?";
            S1[10] = "Sign out?";
            S1[11] = "Transfer?";
            //
            string S2 = "///////";
            //
            string[] S3 = new string[4];
            S3[0] = "Scores";
            S3[1] = "Name:";
            S3[2] = "Yes";
            S3[3] = "to score:";
            //
            string[] S4 = new string[6];
            S4[0] = "Sign in";
            S4[1] = "Password:";
            S4[2] = "Score:";
            S4[3] = "No";
            S4[4] = "Sign out";
            S4[5] = "New Score";
            //
            string[] S5 = new string[3];
            S5[0] = "Sign up";
            S5[1] = "Skip day";
            S5[2] = "Per:";
            //
            string[] S6 = new string[4];
            S6[0] = "Skip day";
            S6[1] = "Exit";
            S6[2] = "Close";
            S6[3] = "Frozen";
            //
            string[] S7 = new string[2];
            S7[0] = "Exit";
            S6[1] = "Transfer";
            //
            string S8 = "Exit";
            //

            //Page 1
            if (page == 1)
            {
                if (strings == 1) {
                    Console.Clear();
                    Console.WriteLine(">>" + S1[0]);
                    Console.WriteLine(S2);
                    Console.WriteLine(S3[0]);
                    Console.WriteLine(S4[0]);
                    Console.WriteLine(S5[0]);
                    Console.WriteLine(S6[0]);
                    Console.WriteLine(S7[0]);
                }
                if (strings == 2)
                {
                    Console.Clear();
                    Console.WriteLine(S1[0]);
                    Console.WriteLine(S2);
                    Console.WriteLine(">>" + S3[0]);
                    Console.WriteLine(S4[0]);
                    Console.WriteLine(S5[0]);
                    Console.WriteLine(S6[0]);
                    Console.WriteLine(S7[0]);
                }
                if (strings == 3)
                {
                    Console.Clear();
                    Console.WriteLine(S1[0]);
                    Console.WriteLine(S2);
                    Console.WriteLine(S3[0]);
                    Console.WriteLine(">>" + S4[0]);
                    Console.WriteLine(S5[0]);
                    Console.WriteLine(S6[0]);
                    Console.WriteLine(S7[0]);
                }
                if (strings == 4)
                {
                    Console.Clear();
                    Console.WriteLine(S1[0]);
                    Console.WriteLine(S2);
                    Console.WriteLine(S3[0]);
                    Console.WriteLine(S4[0]);
                    Console.WriteLine(">>" + S5[0]);
                    Console.WriteLine(S6[0]);
                    Console.WriteLine(S7[0]);
                }
                if (strings == 5)
                {
                    Console.Clear();
                    Console.WriteLine(S1[0]);
                    Console.WriteLine(S2);
                    Console.WriteLine(S3[0]);
                    Console.WriteLine(S4[0]);
                    Console.WriteLine(S5[0]);
                    Console.WriteLine(">>" + S6[0]);
                    Console.WriteLine(S7[0]);
                }
                if (strings == 6)
                {
                    Console.Clear();
                    Console.WriteLine(S1[0]);
                    Console.WriteLine(S2);
                    Console.WriteLine(S3[0]);
                    Console.WriteLine(S4[0]);
                    Console.WriteLine(S5[0]);
                    Console.WriteLine(S6[0]);
                    Console.WriteLine(">>" + S7[0]);
                }
            }
        }
        //
    }
}
