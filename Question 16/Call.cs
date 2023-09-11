using System;
using System.Collections.Generic;

namespace Question_16
{
    // Add a property for keeping a call history – CallHistory, which holds a 
    // list of call records.

    internal class Call
    {
        DateTime date;

        DateTime startCall;

        DateTime durationCall;

        List<Call> callHistory;

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

        internal List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
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
        }

         internal Call(DateTime date, DateTime startCall, DateTime durationCall)
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

        internal void CreateCall()
        {
            Call call1 = new Call();
            Call call2 = new Call("");
            Call call3 = new Call("", "");
            Call call4 = new Call("", "", "");
        }

    }
}