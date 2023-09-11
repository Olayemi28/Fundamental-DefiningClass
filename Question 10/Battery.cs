namespace Question_10
{
    // To the class of mobile phone in the previous two tasks, add a static field
    // nokiaN95, which stores information about mobile phone model Nokia 
    // N95. Add a method to the same class, which displays information about 
    // this static field.

    internal class Battery
    {
        string model;
        string idleTime;
        string hoursTalk;

        internal Battery()
        {

        }

        internal Battery(string model)
        {
            this.model = model;
        }

        internal Battery(string model, string idleTime)
        {
            this.model = model;
            this.idleTime = idleTime;
        }

        internal Battery(string model, string idleTime, string hoursTalk)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.hoursTalk = hoursTalk;
        }
    }
}