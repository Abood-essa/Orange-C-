using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTasks
{
    internal class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
        public string PalletNo { get; set; }
        public string Color { get; set; }

        private bool isEngineRunning;

        public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
            isEngineRunning = false;

        }

        public void StartEngine()
        {
            if (isEngineRunning)
            {
                Console.WriteLine("Engine is already running.");
            }
            else
            {
                isEngineRunning = true;
                Console.WriteLine("Engine started.");
            }
        }

        public void StopEngine()
        {
            if (!isEngineRunning)
            {
                Console.WriteLine("Engine is already stopped.");
            }
            else
            {
                isEngineRunning = false;
                Console.WriteLine("Engine stopped.");
            }
        }

        public string GetCarInfo()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Type: {Type}, Price: {Price}, Pallet No: {PalletNo}, Color: {Color}";
        }

    }
}
