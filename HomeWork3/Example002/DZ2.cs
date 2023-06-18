// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Welcome");
int X1 = Coordinate("X", "A");
int Y1 = Coordinate("y", "A");
int Z1 = Coordinate("Z", "A");
int X2 = Coordinate("X", "B");
int Y2 = Coordinate("Y", "B");
int Z2 = Coordinate("Z", "B");
int Coordinate(string coorName, string pointName)
{
    Console.WriteLine($"Write coordinate {coorName} point {pointName}");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double X1, double X2,
                double Y1, double Y2,
                double Z1, double Z2)
{   
    return Math.Sqrt(Math.Pow((X2 - X1), 2) +
                    Math.Pow((Y2 - Y1), 2) +
                    Math.Pow((Z2 - Z1), 2));
}
double segmentLength = Math.Round(Decision(X1, X2, Y1, Y2, Z1, Z2), 2);
Console.WriteLine($"Segment Length {segmentLength}");
Console.ReadKey();