namespace siapazon;

        internal class Program
        {
             static void Main()
                {

                Console.WriteLine("Начало диапазона");
                int startRange = int.Parse(Console.ReadLine());

                Console.WriteLine("конец диапазона");
                int endRange = int.Parse(Console.ReadLine());

                int a = 0;
                int b = 1;

                Console.WriteLine("кол-тво чисел Фибоначчи");

                while (a <= endRange)
                {
                    if (a >= startRange)
                    {
                        Console.Write(a + " ");
                    }

                    int next = a + b;
                    a = b;
                    b = next;
                }
            }
        }
