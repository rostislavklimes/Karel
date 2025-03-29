
using Karel;
using KarelLanguage.Objects;
using LanguageKarel.Model;

//Console.WriteLine("Hello, World!");
//var robot = new RobotKarel();
//robot.X = 2;
//robot.Y = 3;
//robot.Smer = Smer.Jih;

//Console.WriteLine($"{robot.X} {robot.Y} ");
//robot.Krok();
//Console.WriteLine($"{robot.X} {robot.Y} ");
//robot.Vlevo();
//robot.Krok(); 
//Console.WriteLine($"{robot.X} {robot.Y} ");


var position=new Position(3,4);
var robot = new Robot(position, Direction.North);

Console.WriteLine(robot);
robot.MoveForward();
Console.WriteLine(robot);
robot.TurnLeft();
Console.WriteLine(robot);

Console.ReadLine();