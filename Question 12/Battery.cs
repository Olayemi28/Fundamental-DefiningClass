namespace Question_12
{
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