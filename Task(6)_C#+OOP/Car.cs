using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6__C__OOP
{
    internal class Car
    {
        private string car_make;
        private int car_year;
        private string car_type;
        private double car_price;
        private string car_modle;
        private string car_pallet_numbre;
        private string car_color;
        public Car()
        {

        }
        public Car(string car_make, int car_year, string car_type, double car_price, string car_modle, string car_pallet_numbre, string car_color)
        {
            this.car_make = car_make;
            this.car_year = car_year;
            this.car_type = car_type;
            this.car_price = car_price;
            this.car_modle = car_modle;
            this.car_pallet_numbre = car_pallet_numbre;
            this.car_color = car_color;
        }
        public string carInfo()
        {
            return $"car make : {car_make}, car year : {car_year}, car type : {car_type}, car price : {car_price}, car modle : {car_modle}, car palet number : {car_pallet_numbre}, car color : {car_color} ";
        }
    }
}
