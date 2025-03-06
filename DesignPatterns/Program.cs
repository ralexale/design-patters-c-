// See https://aka.ms/new-console-template for more information

using DesingPatterns.AbstractFactory.Introduction;
using DesingPatterns.AbstractFactory.Introduction.Factories;
using DesingPatterns.Adapter.Example2;
using DesingPatterns.Builder.Burger;
using DesingPatterns.Builder.Robot;
using DesingPatterns.FactoryMethod;
using DesingPatterns.FactoryMethod.Factories;
using DesingPatterns.FactoryMethod.NotificationExercise.Factories;
using DesingPatterns.Prototype.Example1.Shapes;
using DesingPatterns.Prototype.Example2.Monsters;
using DesingPatterns.Singleton;


#region Singleton
//MySingleton singleton1 = MySingleton.GetInstance();
//Console.WriteLine(singleton1.Id);

//MySingleton singleton2 = MySingleton.GetInstance();
//Console.WriteLine(singleton2.Id);
//MySingleton singleton3 = MySingleton.GetInstance();
//Console.WriteLine(singleton3.Id);

//EventLogger logger = EventLogger.GetInstance();
//logger.LogEvent("Aplicacion iniciada");
//logger.LogEvent("Ejecutando tarea 1.");
//logger.LogEvent("Finalizó tarea 1.");
//logger.LogEvent("Terminó la aplicación");


//EventLogger logger2 = EventLogger.GetInstance();
//logger2.LogEvent("Aplicacion iniciada 2");
//logger2.LogEvent("Ejecutando tarea 2.");




//logger.DisplayLogs();
/*logger2.DisplayLogs()*/

#endregion

#region Builder


//IRobotBuilder robotBuilder = new RobotBuilder();
//robotBuilder.BuildArms("brazo-modelo-01");
//robotBuilder.BuildHead("model-head");
//robotBuilder.GetRobot();

//RobotDirector robotDirector = new RobotDirector(robotBuilder);
//robotDirector.ConstructRobot();
//Robot robot = robotBuilder.GetRobot();
//robot.DisplayRobotInfo();

IBurgerBuilder burgerBuilder = new BurgerBuilder();

var burgerJuan = new BurgerBuilder();
BurgerDirector burgerDirector = new BurgerDirector(burgerBuilder);

burgerDirector.MakeCheseeBurger();
var cheeseBurger = burgerBuilder.GetBurger();

burgerBuilder.Reset();

burgerDirector.MakeBaconBurger();
var baconBurger = burgerBuilder.GetBurger();


Console.WriteLine(baconBurger);


#endregion

#region Abstract_Factory

IThemeFactory themeFactory = new MacFactory();
IButton button = themeFactory.CreateButton();
var dropdown = themeFactory.CreateDropdown();
var textBox = themeFactory.CreateTextBox();

button.Render();
dropdown.Render();
textBox.Render();


#endregion

#region FactoryMethod

VehicleFactory vehicleFactory = null;
VehicleFactory motorcycleFactory = new MotorcycleFactory("150");

var flag = true;
while (flag)
{
    Console.WriteLine("\n Please choose a vehicle type: (1) Car, (2) Bike, (3) Motorcycle, 4 quit");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            vehicleFactory = new CarFactory();
            break;
        case 2:
            vehicleFactory = new BikeFactory();
            break;
        case 3:
            vehicleFactory = new MotorcycleFactory("150");
            break;
        default:
            flag = false;
            break;
    }
    var vehicle = vehicleFactory?.OrderVehicle();
    Console.WriteLine($"You have used a {vehicle?.GetType().Name}.");
}


NotificationFactory notificationFactory = null;

//var flag = true;
//while (flag)
//{
//    Console.WriteLine("\n Please choose a notification type: (1) Email, (2) Sms, (3) Push, 4 quit");
//    int choice = Convert.ToInt32(Console.ReadLine());
//    switch (choice)

//    {
//        case 1:
//            notificationFactory = new EmailFactory();
//            break;
//        case 2:
//            notificationFactory = new SmsFactory();
//            break;
//        case 3:
//            notificationFactory = new PushFactory();
//            break;
//        default:
//            flag = false;
//            break;
//    }

//    notificationFactory?.CreateNotification().Send();
//}



#endregion

#region Prototype

var circle = new Circle { Name = "Circle", Id = 1 };
var square = new Square { Name = "Square", Id = 2 };
var rectangle = new Rectangle { Name = "Rectangle", Id = 3 };

circle.Draw();
square.Draw();
rectangle.Draw();

Circle circleClone = (Circle)circle.Clone();
circleClone.Draw();
circleClone.Id = 4;
circleClone.Draw();
circle.Draw();


var vampire = new Vampire(10, "Alucard", 1);
var zombie = new Zombie("DeadC", 15, 2);
var mummy = new Mummy(80, "Ratzu", 3);

vampire.Attack();
zombie.Attack();
mummy.Attack();


Vampire vampireClone = vampire.Clone();

vampireClone.Attack();
vampireClone.Id = 3;
vampireClone.name = "Dracula";
vampireClone.Attack();
vampire.Attack();

#endregion

#region Adapter

var connection = new Connection();

var legacySystem = new LegacySystem();
connection.Start(legacySystem, "Account=asdasd", "clients");


var newSystem = new NewSystem();
// adapter
var orm = new Orm(newSystem);

connection.Start(orm, "Account=asdasd", "clients");

#endregion