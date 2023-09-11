namespace Question_11
{
    internal class Display
    {
        string size;
        string colors;

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