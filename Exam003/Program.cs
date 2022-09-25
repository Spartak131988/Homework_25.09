Console.Write("Введите число: ");
int cube = int.Parse(Console.ReadLine());

void Cube(int[] cube)
{
  int count = 1;
  int length = cube.Length;
  while (count <  length)
  {
    cube[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}

void Print(int[] array)
{
    int size = array.Length;
    int i = 1;

    while (i < size)
    {
        Console.Write(array[i] + " ");
        i ++;
    }
    Console.WriteLine();
} 

int[] col = new int[cube + 1];
Cube(col);
Print(col);