// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Vvedite dva chisla");

            int a, b;
           
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());
 
            if (a > b)
            {
                Console.WriteLine($"Chislo {a} bol'she chem {b}");
            }
            else if (a == b)
            {
                Console.WriteLine("Chisla ravny");
            }
            else
            {
                Console.WriteLine($"Chislo {b} bol'she chem {a}");
            }
