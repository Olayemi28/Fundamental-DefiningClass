namespace Question_13
{
    // Define properties to encapsulate the data in classes GSM, Battery and 
    // Display.

    internal class Battery
    {
        string model;
        string idleTime;
        string hoursTalk;
        BatteryType batteryType;

        internal string Model
        {
            get{return this.model;}
            set{this.model = value;}
        }

        internal string IdleTime
        {
            get{return this.idleTime;}
            set{this.idleTime = value;}
        }

        internal string HoursTalk
        {
            get{return this.hoursTalk;}
            set{this.hoursTalk = value;}
        }

        internal BatteryType batteryType
        {
            get{return this.batteryType;}
            set{this.batteryType = value;}
        }

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

        internal Battery(string model, string idleTime, string hoursTalk,BatteryType batteryType)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }
    }

    internal enum BatteryType
    {
       Li_Ion = 1, 
       NiMH,
       NiCd
    }
}