using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotterne
{
    class Robots
    {
        // Variables
        private string model;
        private string color = "hvid";
        private string chip;
        private bool wifi;
        private bool battery;
        private byte batterySize = 0;
        private byte wheels = 0;
        private bool soap;


        public string Model { get => model; }
        public string Color { get => color; }
        public string Chip { get => chip; }
        public bool Wifi { get => wifi; }
        public bool Battery { get => battery; }
        public byte BatterySize { get => batterySize; }
        public byte Wheels { get => wheels; }
        public bool Soap { get => soap; }

        // We create a constructor, were we use scaffolding.
        public Robots(string model)
        {
            this.model = model;
            Random rng = new Random();
            int choice = rng.Next(0, 2);
            this.chip = choice == 1 ? "RX54667" : "QT8339";
    }
        public Robots(string model, string color) : this(model)
        {
            this.color = color;
        }
        public Robots(string model, string color, bool wifi) : this(model, color)
        {
            this.wifi = wifi;
        }
        public Robots(string model, string color, bool wifi, bool battery, byte batterySize, bool soap, byte wheels) : this(model, color, wifi)
        {
            this.battery = battery;
            this.batterySize = batterySize;
            this.soap = soap;
            this.wheels = wheels;
        }
    }
}
