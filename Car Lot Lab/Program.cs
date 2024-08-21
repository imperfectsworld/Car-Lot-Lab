using Car_Lot_Lab;
int index;

Console.WriteLine("Welcome to the Used Car emporium!");

Car car1 = new Car("Honda", "Civic", 2024, 30000.00m);
Car car2 = new Car("Ford", "Escort", 2020, 55999.99m);
Car car3 = new Car("Tesla", "Cybertruck", 2023, 130000.00m);
UsedCar car4 = new UsedCar("Honda", "Accord", 1999, 5000.00m, 200000);
UsedCar car5 = new UsedCar("Chevy", "Malibu", 2012, 12000.00m, 100000);
UsedCar car6 = new UsedCar("Hyunda", "Elantra", 2001, 1500.00m, 135000);
Car.Inventory.Add(car1);
Car.Inventory.Add(car2);
Car.Inventory.Add(car3);
Car.Inventory.Add(car4);
Car.Inventory.Add(car5);
Car.Inventory.Add(car6);

Car.ListCars(Car.Inventory);

Console.WriteLine("Which car would you like?");
index = int.Parse(Console.ReadLine());

Console.WriteLine(Car.Inventory[index - 1].ToString());



Car.Remove(index);

Car.ListCars(Car.Inventory);
