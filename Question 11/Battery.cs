namespace Question_11
{
    // Add an enumeration BatteryType, which contains the values for type 
    // of the battery (Li-Ion, NiMH, NiCd, …) and use it as a new field for the 
    // class Battery.

    internal class Battery
    {
        string model;
        string idleTime;
        string hoursTalk;
        BatteryType batteryType;

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

    internal enum BatteryType
    {
       Li_Ion = 1, 
       NiMH,
       NiCd
    }
}