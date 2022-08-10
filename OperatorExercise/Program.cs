//Operators Exersice #1
using OperatorExercise;

var add = Methods.Addition();
var minus = Methods.Sub();
var prod = Methods.Mulx();
var quo = Methods.Divide();
var remain = Methods.Remain();

Console.WriteLine($"17 + 4 = {add}");
Console.WriteLine($"17 - 4 = {minus}");
Console.WriteLine($"17 * 4 = {prod} \n17 / 4 = {quo} with a remainder of {remain} ");

//Begin Exercise #2
Console.WriteLine("I see you have a circle \nWhat is the Radius of your circle? ");
var radius = Methods.AreaOfCircle(); 
Console.WriteLine($"The area of your circle is {radius}");








