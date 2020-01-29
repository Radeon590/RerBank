using System;

namespace RerBank
{
    class Render
    {

        //Values
        private int page;
        private int strings;
        //

        //Strings
        private string S1;
        private string S2;
        //

        //Construct
        public Render(int page,int strings)
        {
            this.page = page;
            this.strings = strings;
        }
        //

        //Window
        public void window()
        {
            if (page == 0)
            {
                Console.WriteLine(S1);
            }
        }
        //
    }
}
