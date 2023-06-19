//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Vvedite tsifru, oboznachayushchuyu den' nedeli: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Etot den' vykhodnoy? - DA");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Eto ne den' nedeli");
  }
  else Console.WriteLine("Etot den' vykhodnoy? - NET");
}

CheckingTheDayOfTheWeek(dayNumber);