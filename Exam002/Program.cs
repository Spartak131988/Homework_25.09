int x1 = Coordinate(" A1 ");
int y1 = Coordinate(" A2 ");
int z1 = Coordinate(" A3 ");
int x2 = Coordinate(" B1 ");
int y2 = Coordinate(" B2 ");
int z2 = Coordinate(" B3 ");

int Coordinate(string coor)
{
    Console.Write("Введите координаты точки" + coor);
    return int.Parse(Console.ReadLine()); 
}


double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double Cutlength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine("Длина отрезка: " + Cutlength);