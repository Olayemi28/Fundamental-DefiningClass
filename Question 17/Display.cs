namespace Question_17
{
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