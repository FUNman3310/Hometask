using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibrary
{
    internal class Gallery
    {
        public int Id;
        public string Name;
        Car[] Cars = new Car[0];

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length+1);
            Cars[Cars.Length-1] = car;
        }

        public void ShowAllCars()
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                Console.WriteLine($"Name-{Cars[i].Name} Id-{Cars[i].Id} CarCode-{Cars[i].CarCode} Speed-{Cars[i].Speed}");
            }
        }

        public Car[] GetAllCars()
        {
            return Cars;
        }

        public Car FindCarById(int id)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Id == id)
                {
                    return Cars[i];
                }
            }
            return null;
        }

        public Car FindCarByCarCode(string carCode)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].CarCode == carCode)
                {
                    return Cars[i];
                }
            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(int min, int max)
        {
            Car[] SpeedCars = new Car[0];
            for (int i = 0; i < Cars.Length; i++)
            {
                if (min<Cars[i].Speed&&Cars[i].Speed<max)
                {
                    Array.Resize(ref SpeedCars, SpeedCars.Length+1);
                    SpeedCars[SpeedCars.Length-1] = Cars[i];
                }
            }
            if (SpeedCars.Length!=0)
            {
                return SpeedCars;
            }
            else
            {
                return null;
            }
        }
    }
}
