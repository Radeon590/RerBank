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
            if ((int)key == 13) {
                page++;
            }
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
