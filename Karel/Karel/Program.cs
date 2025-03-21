
using Karel;

Console.WriteLine("Hello, World!");
var robot = new RobotKarel();
robot.X = 2;
robot.Y = 3;
robot.Smer = Smer.Jih;

Console.WriteLine($"{robot.X} {robot.Y} ");
robot.Krok();
Console.WriteLine($"{robot.X} {robot.Y} ");
robot.Vlevo();
robot.Krok(); 
Console.WriteLine($"{robot.X} {robot.Y} ");
