namespace Question_9
{
    // Declare several constructors for each of the classes created by the 
    // previous task, which have different lists of parameters (for complete 
    // information about a student or part of it). Data fields that are unknown 
    // have to be initialized respectively with null or 0.

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