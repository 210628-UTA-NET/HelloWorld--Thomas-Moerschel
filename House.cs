using System;

namespace HouseFunction
{
    public class House
    {
        private string _color;
        private int _price;

        public House()
        {
            Console.WriteLine("The constructor of class 'House' was used.");
            _color = "Red";
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        
        public string Name {get;set;}

        public string getColor()
        {
            return _color;
        }
        public void setColor(string p_color)
        {
            _color = p_color;
        }

    }
}