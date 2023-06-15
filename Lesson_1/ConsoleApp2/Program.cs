// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Vvedite tri chisla");

            int a, b, c;
           
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());
             c = Convert.ToInt32(Console.ReadLine());
 
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else if (c > b && c > a) 
            {
                Console.WriteLine(c);
            }
            else
            {
               Console.WriteLine("Chisla ravny");
            }
                