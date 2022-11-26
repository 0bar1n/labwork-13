using System;

namespace labwork_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n"); //просим ввести переменную
            int n = int.Parse(Console.ReadLine()); //ввод и задание целочисленной переменной
            int[] mass1 = new int[n+1]; //объявление целочисленного массива
            int[] mass2 = new int[n+2]; //объявление целочисленного массива

            Console.WriteLine("Введите p"); //просим ввести переменную
            int p = int.Parse(Console.ReadLine()); //ввод и задание целочисленной переменной
            Console.WriteLine("Введите число q"); //просим ввести переменную
            int q = int.Parse(Console.ReadLine()); //ввод и задание целочисленной переменной

            Random r = new Random(); //случайная переменная в диапазоне
            Console.WriteLine("Первый массив"); //вывод на консоль
            for (int i = 0; i < mass1.Length; ++i) //цикл, пока верно условие
            {
                mass1[i] = r.Next(0, 100); //задание массива
                Console.Write(mass1[i] + " "); //вывод на консоль массива
            }
            Console.WriteLine(""); //

            Console.WriteLine("Второй массив"); 
            for (int i = 0; i < mass2.Length; ++i) //цикл, пока верно условие
            {
                mass2[i] = r.Next(0, 100); //задание массива
                Console.Write(mass2[i] + " "); //вывод на консоль массива
            }

            int[,] a = new int[n+1, n+2]; //обявление размерности нового массива

            Console.WriteLine(" "); //

            for (int i = 0; i < n + 1; i++) //цикл, пока верно условие

                for (int j = 0; j < n + 2; j++) //цикл, пока верно условие
                {

                    a[i, j] = Convert.ToInt32(r.Next(0, 100)); //задание матрицы
                    
                }

            for (int i = 0; i < n + 1; i++) //цикл, пока верно условие
                {
                    a[p, i] = mass1[i]; //задание p+1 строки матрицы
                    a[i, q] = mass2[i]; //задание q+1 столбца матрицы
                }


            Console.WriteLine(" "); //

            Console.WriteLine("Новая матрица"); //вывод на консоль
            for (int i = 0; i < n+1; i++) //цикл, пока верно условие
            {
                Console.WriteLine(); //
                for (int j = 0; j < n + 2; j++) //цикл, пока верно условие
                {
                    Console.Write("{0}\t", a[i, j]); //вывод новой матрицы
                }
            }
        }
    }
}
