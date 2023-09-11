namespace Question_14
{
    // Write a class GSMTest, which has to test the functionality of class GSM. 
    // Create few objects of the class and store them into an array. Display 
    // information about the created objects. Display information about the 
    // static field nokiaN95.

    internal class Display
    {
        string size;
        string colors;

        internal string Size
        {
            get{return this.size;}
            set{this.size = value;}
        }

        internal string Colors
        {
            get{return this.colors;}
            set{this.colors = value;}
        }

        internal Display()
        {
            
        }

        internal Display(string size)
        {
            this.size = size;
        }

        internal Display(string size, string colors)
        {
            this.size = size;
            this.colors = colors;
        }
    }    
}