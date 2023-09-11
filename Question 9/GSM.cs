namespace Question_9
{
    // Declare several constructors for each of the classes created by the 
    // previous task, which have different lists of parameters (for complete 
    // information about a student or part of it). Data fields that are unknown 
    // have to be initialized respectively with null or 0.

    internal class GSM
    {
        string model;
        string manufacturer;
        decimal price;
        string owner;

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
    }
}