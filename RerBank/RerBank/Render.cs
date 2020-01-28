using System;

namespace RerBank
{
    class Render
    {

        //Values
        private int page;
        private int Acc = 0;
        //

        //Strings
        private string S1 = "/////////RerBank/////////";
        private string S2_0 = "//Menu//";
        private string S2_1 = "//Scores//";
        private string S2_2 = "";
        //

        //Construct
        public Render(int page)
        {
            this.page = page;
        }
        //

        //Geter and Seter
        public int getPage() {return page;}
        public void setPage(int page) { this.page = page;}
        //

        //Window
        public void Window()
        {
            if (page == 0)
            {
                Console.WriteLine(S1);
                Console.WriteLine(S2_0);
            }
        }
        //
    }
}
