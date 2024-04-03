using Core.Models;
namespace Access_Modifiers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car1=new Car();
            car1.Id = 250;
            car1.Name = "BMW";
            car1.Speed = 240;
            car1.CarCode = "AB1001";

            Car car2 = new Car();
            car2.Id = 350;
            car2.Name = "BMW";
            car2.Speed = 260;
            car2.CarCode = "BC1002";
            
            Car car3 = new Car();
            car3.Id = 320;
            car3.Name = "Mercedes-Benz";
            car3.Speed = 260;
            car3.CarCode = "CD1003";

            Gallery gallery = new Gallery();
            gallery.AddCar(car1);
            gallery.AddCar(car2);
            gallery.AddCar(car3);

            int choice;
            do
            {
                Console.WriteLine("Menu:\n 1.Masin elave et.\n 2.Butun masinlari goster.\n 3.Axtaris et.\n 0.Proqrami bitir.");
                choice=Convert.ToInt32(Console.ReadLine());


                if (choice == 1)
                {
                    string idStr = " ";
                    int id;
                    do
                    {
                        Console.WriteLine("Id daxil edin:");
                        idStr=Console.ReadLine();
                    }
                    while(!int.TryParse(idStr, out id));

                    Console.WriteLine(" ");
                    Console.WriteLine("Name daxil edin");
                    string name= Console.ReadLine();


                    Console.WriteLine(" ");
                    string speedStr = " ";
                    int speed;
                    do
                    {
                        Console.WriteLine("Suretini daxil edin");
                        speedStr=Console.ReadLine();
                    }
                    while(!int.TryParse(speedStr, out speed));

                    string carcode;
                    do
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("CarCode daxil edin:");
                        carcode = Console.ReadLine();
                        if (carcode.Length != 6 || !char.IsUpper(carcode[0]) || !char.IsUpper(carcode[1]))
                        {
                            Console.WriteLine("CarCode duzgun daxil edilmeyib!");
                        }

                    }
                    while (carcode.Length != 6 || !char.IsUpper(carcode[0]) || !char.IsUpper(carcode[1]));
                    
                   

                    Car car = new Car();
                    car = new Car(id, name, speed,carcode); 

                    gallery.AddCar(car);

                    Console.WriteLine("Yeni masin elave edildi.");

                }
                else if (choice == 2)
                {
                    gallery.ShowAllCars();
                    
                }
                else if (choice == 3)
                {
                    Console.WriteLine(" ");
                    int check;
                    do
                    {
                        Console.WriteLine(" 1.Id gore axtaris et\n 2.Carcode gore axtaris et\n 3.Surete gore axtaris et\n 0.Esas menyuya qayit");
                        check=Convert.ToInt32(Console.ReadLine());

                        if(check == 1)
                        {
                            Console.WriteLine(" ");
                            string idStr = " ";
                            int id;
                            do
                            {
                                Console.WriteLine("Id daxil edin:");
                                idStr=Console.ReadLine();

                            }
                            while(!int.TryParse(idStr, out id));

                            for (int i = 0; i < gallery.FindCarById(id).Length; i++)
                            {
                                Console.WriteLine($"Id:{gallery.FindCarById(id)[i].Id}\n" +
                                                  $"Name:{gallery.FindCarById(id)[i].Name}\n" +
                                                  $"Speed:{gallery.FindCarById(id)[i].Speed}\n" +
                                                  $"CarCode:{gallery.FindCarById(id)[i].CarCode}");
                                Console.WriteLine("----------------------------------------");
                            }
                        }
                        else if (check == 2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Carcode daxil edin:");
                            string carCode= Console.ReadLine();

                            for (int i = 0; i < gallery.FindCarByCarCode(carCode).Length; i++)
                            {
                                Console.WriteLine($"Id:{gallery.FindCarByCarCode(carCode)[i].Id}\n" +
                                                  $"Name:{gallery.FindCarByCarCode(carCode)[i].Name}\n" +
                                                  $"Speed:{gallery.FindCarByCarCode(carCode)[i].Speed}\n" +
                                                  $"CarCode:{gallery.FindCarByCarCode(carCode)[i].CarCode}");
                                Console.WriteLine("----------------------------------------");
                            }
                        }
                        else if(check==3)
                        {
                            Console.WriteLine(" ");
                            string minSpeedStr = " ";
                            int minSpeed;
                            do
                            {
                                Console.WriteLine(" Min sureti daxil edin:");
                                minSpeedStr=Console.ReadLine();
                            }
                            while(!int.TryParse(minSpeedStr, out minSpeed));

                            Console.WriteLine(" ");
                            string maxSpeedStr=" ";
                            int maxSpeed;
                            do
                            {
                                Console.WriteLine("Max sureti daxil edin:");
                                maxSpeedStr=Console.ReadLine();
                            }
                            while (!int.TryParse(maxSpeedStr, out maxSpeed));

                           

                            for (int i = 0; i < gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed).Length; i++)
                            {
                                Console.WriteLine($"Id:{gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed)[i].Id}\n" +
                                                  $"Name:{gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed)[i].Name}\n" +
                                                  $"Speed:{gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed)[i].Speed}\n" +
                                                  $"CarCode:{gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed)[i].CarCode}");
                                Console.WriteLine("----------------------------------------");
                            }
                        }
                    }
                    while(check!=0);
                }
                
            }
            while (choice != 0);
            Console.WriteLine("Proqram bitdi!");

        }
    }
}
