namespace Question_9
{
    // Declare several constructors for each of the classes created by the 
    // previous task, which have different lists of parameters (for complete 
    // information about a student or part of it). Data fields that are unknown 
    // have to be initialized respectively with null or 0.

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