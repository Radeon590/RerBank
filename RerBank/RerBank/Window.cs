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
        public Window(int page, int strings)
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
            const string S = "//////";
            const string S0 = "Menu";
            const string S1 = "Scores";
            const string S2 = "Sign in";
            const string S3 = "Sign up";
            const string S4 = "Sign out?";
            const string S5 = "Skip day?";
            const string S6 = "Close?";
            const string S7 = "Exit?";
            const string S8 = "Froze?";
            const string S9 = "Transfer to:";
            const string S10 = "Unfroze?";
            const string S11 = "Transfer?";
            const string S12 = "Name:";
            const string S13 = "Password:";
            const string S14 = "Yes";
            const string S15 = "No";
            const string S16 = "to score:";
            const string S17 = "Score:";
            const string S18 = "New Score";
            const string S19 = "Per:";
            const string S20 = "Exit";
            const string S21 = "Close";
            const string S22 = "Froze";
            const string S23 = "Transfer";
            const string S24 = "Sign out";
            const string S25 = "Skip day";
            const string S26 = "Unfroze";
            //
                
                //Page 1
                if (page == 1)
                {
                //str
                if (strings == 1)
                {
                    Console.WriteLine(S0);
                    Console.WriteLine(S);
                    Console.WriteLine(">>" + S1);
                    Console.WriteLine(S2);
                    Console.WriteLine(S3);
                    Console.WriteLine(S25);
                    Console.WriteLine(S20);
                }
                else if (strings == 2) 
                {

                    Console.WriteLine(S0);
                    Console.WriteLine(S);
                    Console.WriteLine(S1);
                    Console.WriteLine(">>" + S2);
                    Console.WriteLine(S3);
                    Console.WriteLine(S25);
                    Console.WriteLine(S20);
                }
                else if (strings == 3)
                {
                    Console.WriteLine(S0);
                    Console.WriteLine(S);
                    Console.WriteLine(S1);
                    Console.WriteLine(S2);
                    Console.WriteLine(">>" + S3);
                    Console.WriteLine(S25);
                    Console.WriteLine(S20);
                }
                else if (strings == 4)
                {
                    Console.WriteLine(S0);
                    Console.WriteLine(S);
                    Console.WriteLine(S1);
                    Console.WriteLine(S2);
                    Console.WriteLine(S3);
                    Console.WriteLine(">>" + S25);
                    Console.WriteLine(S20);
                }
                else if (strings == 5)
                {
                    Console.WriteLine(S0);
                    Console.WriteLine(S);
                    Console.WriteLine(S1);
                    Console.WriteLine(S2);
                    Console.WriteLine(S3);
                    Console.WriteLine(S25);
                    Console.WriteLine(">>" + S20);
                }

                }
                //

                //Page2
                if (page == 2) {
                    Console.WriteLine(S1);
                    Console.WriteLine(S);
                }
                //

                //Page3
                if (page == 3) {
                    Console.WriteLine(S2);
                    Console.WriteLine(S);
                    Console.WriteLine(S12);
                    Console.WriteLine(S13);
                }

                //Page4
                if (page == 4) {
                    Console.WriteLine(S);
                    Console.WriteLine(S17);
                }

                //Page5
                if (page == 5) {
                    Console.WriteLine(S3);
                    Console.WriteLine(S);
                    Console.WriteLine(S12);
                    Console.WriteLine(S13);
                }
                //

                //Page6
                if (page == 6) {
                    if (strings == 1) {
                        Console.WriteLine(S5);
                        Console.WriteLine(S);
                        Console.WriteLine(">>" + S14);
                        Console.WriteLine(S15);
                    } else if (strings == 2) {
                        Console.WriteLine(S5);
                        Console.WriteLine(S);
                        Console.WriteLine(S14);
                        Console.WriteLine(">>" + S15);
                    }
                }
            //

        }
        //
    }
}
