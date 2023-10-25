using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Module_03
{
    internal class Assignment
    {
        public string Parking(string input)
        {
            try
            {
                int parkingSpots = int.Parse(input);
                List<(int, int)> occupied = new List<(int, int)>();
                int left = 0;

                for (int i = 0; i < parkingSpots; i++)
                {
                    occupied.Add((0, 0)); // Initialize parking spots as unoccupied
                }
                string time = Console.ReadLine();
                string[] hours = time.Split(' ');

                for (int i = 0; i < hours.Length; i++)
                {
                    string[] hour = hours[i].Split(':');
                    int arrive = int.Parse(hour[0]);
                    int duration = int.Parse(hour[1]);

                    // Check for available parking spot
                    bool parked = false;
                    for (int j = 0; j < parkingSpots; j++)
                    {
                        if (occupied[j].Item1 <= arrive)
                        {
                            occupied[j] = (arrive + duration, i);
                            parked = true;
                            break;
                        }
                    }

                    // If no parking spot was found, the car had to leave
                    if (!parked)
                    {
                        left++;
                    }
                }

                return left.ToString();
            }
            catch
            {
                return "Crazy input!";
            }
        }
    }
}
