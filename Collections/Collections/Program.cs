using Collections;

//Collections and data structures documentation: https://learn.microsoft.com/en-us/dotnet/standard/collections/


//ICollection implementation - HashSet<T>
var cars = new HashSet<Car>
{
    new Car { Make = "Skoda", Model = "Octavia RS", MaxSpeed = 250},
    new Car { Make = "Skoda", Model = "Superb", MaxSpeed = 250},
    new Car { Make = "Seat", Model = "Cupra Formentor", MaxSpeed = 260}
};

cars.Add(new Car { Make = "OneMore", Model = "CarToAdd", MaxSpeed = 300 });

//IList implemenataion - List<T>
var carsList = new List<Car>
{
    new Car { Make = "Skoda", Model = "Octavia RS", MaxSpeed = 250},
    new Car { Make = "Skoda", Model = "Superb", MaxSpeed = 250},
    new Car { Make = "Seat", Model = "Cupra Formentor", MaxSpeed = 260}
};

//insert at specific index
carsList.Insert(2, new Car { Make = "VW", Model = "Passat", MaxSpeed = 265 });

Console.WriteLine($"Last added car is {carsList[2].Model}");    //Passat


//Dictionary - Collection with user defined index (key)
var carDict = new Dictionary<string, Car>
{
    { "FavoriteCar", new Car { Make = "Skoda", Model = "Octavia"} },
    { "SecondFavoriteCar", new Car { Make = "Skoda", Model = "Superb"} },
};

//access dictionaty item using defined index
var myFavoriteCar = carDict["FavoriteCar"];

Console.WriteLine($"My favourite car is {myFavoriteCar.Make} - {myFavoriteCar.Model}");

//Queue (FIFO - First In First Out) - IEnumerable implementation
var carWashQueue = new Queue<Car>();
carWashQueue.Enqueue(new Car { Make = "Skoda", Model = "Octavia RS", MaxSpeed = 250 }); //Adds new items to the queue
carWashQueue.Enqueue(new Car { Make = "Skoda", Model = "Superb", MaxSpeed = 250 });
carWashQueue.Enqueue(new Car { Make = "Seat", Model = "Cupra Formentor", MaxSpeed = 260 });

var firstCleanCar = carWashQueue.Dequeue();
Console.WriteLine($"First clean car is {firstCleanCar.Make} - {firstCleanCar.Model}");  //first added

//Stack - LIFO (Last In First Out) - IEnumerable implementation
var deadEndStreetParkingQueue = new Stack<Car>();
deadEndStreetParkingQueue.Push(new Car { Make = "Skoda", Model = "Octavia RS", MaxSpeed = 250 });
deadEndStreetParkingQueue.Push(new Car { Make = "Skoda", Model = "Superb", MaxSpeed = 250 });
deadEndStreetParkingQueue.Push(new Car { Make = "Seat", Model = "Cupra Formentor", MaxSpeed = 260 });

var firstToLeave = deadEndStreetParkingQueue.Pop();
Console.WriteLine($"The first car to leave is {firstToLeave.Make} - {firstToLeave.Model}"); //last added