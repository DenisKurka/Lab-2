using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Address
    {
        private int Index;
        private string Country;
        private string City;
        private string Street;
        private string House;
        private string Apartment;

        public int index
        {
            get
            {
                return Index;
            }

            set
            {
                this.Index = value;
            }
        }
        public string country
        {
            get
            {
                return Country;
            }

            set
            {
                this.Country = value;
            }
        }

        public string city
        {
            get
            {
                return City;
            }

            set
            {
                this.City = value;
            }
        }

        public string street
        {
            get
            {
                return Street;
            }

            set
            {
                this.Street = value;
            }
        }

        public string house
        {
            get
            {
                return House;
            }

            set
            {
                this.House = value;
            }
        }

        public string apartment
        {
            get
            {
                return Apartment;
            }

            set
            {
                this.Apartment = value;
            }
        }



        public void Display()
        {
            Console.WriteLine($"Ваш индекс: {index}");
            Console.WriteLine($"Ваша страна: {country}");
            Console.WriteLine($"Ваш город: {city}");
            Console.WriteLine($"Ваша улица: {street}");
            Console.WriteLine($"Ваш дом: {house}");
            Console.WriteLine($"Ваша квартира: {apartment}");
        }


    }
}
