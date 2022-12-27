// Напишите программу, которая принимает на вход пятизначное число и проверяет
// является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

// Console.Write("Введите число N: ");
// string s = Console.ReadLine();
//         int[] num1 = new int[s.Length]; 
//         for (int i = 0; i < s.Length; i++)
//         {
//             num1[i] = s[i];
//             Console.WriteLine(num1[i]);
//         }
string num1 = (Console.ReadLine()) ;  ///  {123455}
        int nubmerLength = num1.Length;
        Console.WriteLine(num1.Length);
        bool f = true;
        for (int i = 0; i < nubmerLength/2; i++)
        {
            //System.Console.WriteLine($"[{num1}]  ->  {num1[i]} - {num1[nubmerLength-1-i]} ->  i={i}, nubmerLength-i-1= {nubmerLength-1-i}, {nubmerLength}");
            if (num1[i] != num1[nubmerLength -1-i])
            {
                f = false;
                break;
            }
        }
        if (f == true)
        {
            Console.Write($"Число {num1} палиндром");
        }
        else
        {
            Console.Write($"Число {num1} не палиндром");
        }