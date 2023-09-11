using System;
using System.Collections.Generic;

namespace Question_17
{
    internal class Call
    {
        string date;

        string startCall;

        string durationCall;

        List<string> callHistory;

        internal string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        internal string StartCall
        {
            get { return this.startCall; }
        }

        internal string DurationCall
        {
            get { return this.durationCall; }
            set { this.durationCall = value; }
        }

        internal List<string> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        internal Call()
        {

        }

        internal Call(string date)
        {
            this.date = date;
        }

        internal Call(string date, string startCall)
        {
            this.date = date;
            this.startCall = startCall;
        }

        internal Call(string date, string startCall, string durationCall)
        {
            this.date = date;
            this.startCall = startCall;
            this.durationCall = durationCall;
        }

        public override string ToString()
        {
            return $"{this.date} {this.startCall} {this.durationCall}";
        }
    }
}