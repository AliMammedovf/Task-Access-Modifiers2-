using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }

        Car[] Cars = new Car[] { };
        public Gallery()
        {
            
        }

        public Gallery(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1); 
            Cars[Cars.Length-1] = car;
    
        }

        public void ShowAllCars()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"Id:{car.Id}\nName:{car.Name}\nSpeed:{car.Speed}\nCarCode:{car.CarCode}");
                Console.WriteLine("----------------------------------------");
            }
        }

        public Car[] GetAllCars()
        {
            Car[] GetCar=new Car[] { };
            for (int i = 0; i < Cars.Length; i++)
            {
                Array.Resize(ref GetCar, GetCar.Length + 1);
                GetCar[Cars.Length-1]= Cars[i];
                Console.WriteLine("--------------------------");
            }
            return GetCar;
        }
        public Car[] FindCarById(int id)
        {
            Car[] FindCarId=new Car[] { };

            for(int i = 0;i < Cars.Length;i++)
            {
                if (Cars[i].Id == id)
                {
                    Array.Resize(ref FindCarId, FindCarId.Length + 1);
                    FindCarId[FindCarId.Length-1]= Cars[i];
                }
            }
            return FindCarId;
        }
        public Car[] FindCarByCarCode(string carCode)
        {
            Car[] FindCarCode=new Car[] { };
            for( int i = 0;i< Cars.Length; i++)
            {
                if (Cars[i].CarCode == carCode)
                {
                    Array.Resize(ref FindCarCode, FindCarCode.Length + 1);
                    FindCarCode[FindCarCode.Length-1]= Cars[i];
                }
            }
            return FindCarCode;
        }
        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Car[] SpeedCar = new Car[] { };

            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Speed>=minSpeed && Cars[i].Speed<=maxSpeed)
                {
                    Array.Resize(ref SpeedCar, SpeedCar.Length+1);
                    SpeedCar[SpeedCar.Length-1]= Cars[i];
                }
            }
            return SpeedCar;
        }
    }
}
