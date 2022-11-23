using NewLibrary;
Car Var;
Car[] CarArr;
Car car1 = new Car("Ferrari", 120);
Car car2 = new Car("Lambo", 20);
Car car3 = new Car("Mazda", 60);
Car car4 = new Car("Volga", 320);

Gallery gallery = new Gallery()
{
    Id = 1,
    Name = "Nomre1",
};

gallery.AddCar(car1);
gallery.AddCar(car2);
gallery.AddCar(car3);
gallery.AddCar(car4);

gallery.ShowAllCars();

CarArr = gallery.GetAllCars();

Var = gallery.FindCarById(3);
Var = gallery.FindCarByCarCode("MA1003");

CarArr = gallery.FindCarsBySpeedInterval(30, 150);