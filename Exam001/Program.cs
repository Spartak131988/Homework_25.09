Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void Palindrome(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine("Число является палиндромом");
  }
  else
  {
    Console.WriteLine("Число не является палиндромом");
  }
}

if (number.Length == 5)
{
  Palindrome(number);
}
else Console.WriteLine("Введите правильное число");