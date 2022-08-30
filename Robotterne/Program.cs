using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotterne
{
    class Program
    {
        // This asignment could be interpret different ways and therefore I have coded this assignment as I interpret it.
        static void Main(string[] args)
        {
            // Variables
            string model;
            string color;
            string wifiYesNo;
            bool wifi = false;
            bool battery = false;
            byte batterySize = 0;
            bool soap = false;
            byte wheels = 0;

            // We input the needed model of the robot
            Console.WriteLine("Vælg hvilken robot model du ønsker?");
            Console.WriteLine("Roomba, Vinduespudser, Dækskifter");
            model = Console.ReadLine().ToLower();

            // we input the color of the robot
            Console.WriteLine();
            Console.WriteLine("Vælg farve");
            Console.WriteLine("Hvid, Rød, Blå");
            color = Console.ReadLine().ToLower();

            // We answer if the robot should have wifi
            Console.WriteLine();
            Console.WriteLine("Vil du have Wifi? (y/n)");
            wifiYesNo = Console.ReadLine().ToLower();

            if (wifiYesNo == "y")
            {
                wifi = true;
            }
            else
            {
                wifi = false;
            }

            // Depending on our input above we have different cases. We use an if/else statement to to get into the different cases. 
            if (model == "roomba")
            {
                soap = true; 
            }
            else if(model == "vinduespudser")
            {
                soap = true;

                Console.WriteLine();
                Console.WriteLine("Hvor mange hjul vil du have på? ");
                wheels = byte.Parse(Console.ReadLine());
            }
            else if(model == "dækskifter")
            {
                Console.WriteLine();
                Console.WriteLine("Hvor mange hjul vil du have på? ");
                wheels = byte.Parse(Console.ReadLine());

                if (color != "hvid")
                {
                    battery = false;
                }
                else
                {
                    battery = true;
                    Console.WriteLine();
                    Console.WriteLine("Hvor stort skal batteriet være fra 1 til 255?");
                    batterySize = byte.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Indtast venligst en af de 3 typer vi kan producere");
            }


            // We create a robot
            Robots robot = new Robots(model, color, wifi, battery, batterySize, soap, wheels);
            Console.WriteLine();
            // We output the robot.
            Console.WriteLine($"Chip: {robot.Chip}\r\nModel: {robot.Model}\r\nColor: {robot.Color}\r\nWifi: {robot.Wifi}\r\nBattery: {robot.Battery}\r\nBatterySize: {robot.BatterySize}\r\nSoapThingy: {robot.Soap}\r\nWheels: {robot.Wheels}");

            Console.ReadLine();
        }
    }
}
