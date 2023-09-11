namespace Question_10
{
    // To the class of mobile phone in the previous two tasks, add a static field
    // nokiaN95, which stores information about mobile phone model Nokia 
    // N95. Add a method to the same class, which displays information about 
    // this static field.

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