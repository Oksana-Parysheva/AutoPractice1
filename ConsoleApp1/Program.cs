using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;

            Console.Write("Ввведите стороны для 3 треугольников: ");
            Triangle[] triangleArr = new Triangle[3];

            for (int i = 0; i < triangleArr.Length; i++)
            {
                Console.WriteLine("\nТреугольник №{0}:", i + 1);
                triangleArr[i].A = EnterTriangleSide(Side.A);
                triangleArr[i].B = EnterTriangleSide(Side.B);
                triangleArr[i].C = EnterTriangleSide(Side.C);
            }

            int maxPerimeter = triangleArr[0].GetPerimeter();
            for (int i = 1; i < triangleArr.Length; i++)
            {
                if (maxPerimeter < triangleArr[i].GetPerimeter())
                {
                    maxPerimeter = triangleArr[i].GetPerimeter();
                }
            }

            Console.WriteLine("Максимальный периметр у треугольника равен {0}", maxPerimeter);

            Console.ReadKey();
        }

        static int EnterTriangleSide(Side side)
        {
            switch (side)
            {
                case Side.A:
                    Console.Write("\n\tсторона а = ");
                    return Convert.ToInt16(Console.ReadLine());
                case Side.B:
                    Console.Write("\n\tсторона b = ");
                    return Convert.ToInt16(Console.ReadLine());
                case Side.C:
                    Console.Write("\n\tсторона c = ");
                    return Convert.ToInt16(Console.ReadLine());
                default:
                    return 0;
            }
        }

        enum Side
        {
            A,
            B,
            C
        }

        struct Triangle
        {
            public int A;
            public int B;
            public int C;

            public int GetPerimeter()
            {
                return A + B + C;
            }
        }

        static void Task1()
        {
            Console.Write("Введите строку произвольной длинны -> ");
            string str = Console.ReadLine();

            Console.Write("Какой символ искать в строке -> ");
            char ch = Console.ReadKey().KeyChar;

            int i = 0;
            foreach (var el in str.ToCharArray())
            {
                if (el.Equals(ch))
                {
                    i++;
                }
            }

            int result = 100 * i / str.Length;

            Console.WriteLine("\nПроцент вхождения символа {0} равен {1}%", ch, result);
        }
    }
}
