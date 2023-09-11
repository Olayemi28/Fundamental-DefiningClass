using System;

namespace Question_15
{
    internal class Call
    {
        DateTime date;

        DateTime startCall;

        DateTime durationCall;

        internal DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        internal DateTime StartCall
        {
            get { return this.startCall; }
        }

        internal DateTime DurationCall
        {
            get { return this.durationCall; }
            set { this.durationCall = value; }
        }

        internal Call()
        {

        }

        internal Call(DateTime date)
        {
            this.date = date;
        }

        internal Call(DateTime date, DateTime startCall)
        {
            this.date = date;
            this.startCall = startCall;
            this.durationCall = durationCall + CallDuration();
        }

        private TimeSpan CallDuration()
        {
            var duration = DateTime.Now - this.startCall;
            return duration;
        }
    }
}