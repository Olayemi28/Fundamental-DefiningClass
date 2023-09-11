using System;
namespace Question_10
{
    // To the class of mobile phone in the previous two tasks, add a static field
    // nokiaN95, which stores information about mobile phone model Nokia 
    // N95. Add a method to the same class, which displays information about 
    // this static field.

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

        internal void DisplayNokia()
        {
            Console.WriteLine($"The model of the latest nokia battery is {NokiaN95}");
        }
    }
}