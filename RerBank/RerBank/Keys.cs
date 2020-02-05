using System;
namespace RerBank
{
    class Keys
    {
        private int page = 1;
        private char key;
        private int strings = 1;

        //Constructor
        public Keys(char key) {
            this.key = key;
        }
        //

        //keyKnow
        public void keyKnow() {
            bool works = true;
            //
            if (key == 'S') {
                strings++;
            } 
            if (key == 'W') { 
            strings--;
            }
            //Enter
            if ((int)key == 13) {

                //P1
                if (page == 1) {

                    if (strings == 1)
                    {
                        page = 2;
                        strings = 1;
                    }
                    else if (strings == 2)
                    {
                        page = 3;
                        strings = 1;
                    }
                    else if (strings == 3)
                    {
                        page = 5;
                        strings = 1;
                    } else if (strings == 4)
                    {
                        page = 6;
                        strings = 1;
                    }
                }
                //

                if (page == 3) { 
                
                }

                //P6
                if (page == 6) {

                    if (strings == 1)
                    {
                        page = 1;
                        strings = 1;
                    }
                    else if (strings == 2) {
                        page = 1;
                        strings = 1;
                    }
                }
                //
            }
            //

            //
            while (works == true) {
                Window r = new Window(page, strings);
                r.window();
            }
            //
        }
        //
    }
}
