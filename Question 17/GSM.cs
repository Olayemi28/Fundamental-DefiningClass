using System;

namespace Question_17
{
    // In GSM class add methods for adding and deleting calls (Call) in the 
    // archive of mobile phone calls. Add method, which deletes all calls from 
    // the archive.

    internal class GSM
    {
        string model;
        string manufacturer;
        decimal price;
        string owner;
        static string nokiaN95 = "NokiaN95";

        internal string NokiaN95
        {
           get {return nokiaN95;}
        }

        internal string Model
        {
            get{return this.model;}
            set{this.model = value;}
        }

        internal string Manufacturer
        {
            get{return this.manufacturer;}
            set{this.manufacturer = value;}
        }

        internal decimal Price
        {
            get{return this.price;}
            set{this.price = value;}
        }

        internal string Owner
        {
            get{return this.owner;}
            set{this.owner = value;}
        }

        internal GSM()
        {

        }

        internal GSM(string model)
        {
            this.model = model;
        }

        internal GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        internal GSM(string model, string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        internal GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public override string ToString()
        {
            return $"Model:{this.model}\tManufacturer:{this.manufacturer}\tPrice:{this.price}\tOwner:{this.owner}";
        }

        internal void DisplayNokia()
        {
            Console.WriteLine($"The model of the latest nokia battery is {NokiaN95}");
        }

        internal void AddCall()
        {
            Call call = new Call("10-09-2022",  "10:53", "3");
            Call call1 = new Call();
            call1.CallHistory.Add(call.ToString());
        }
    }
}