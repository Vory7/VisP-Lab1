using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming
{
    public class HW1
    {
        public static long QueueTime(int[] clients, int n)
        {
            int[] sellers = new int[n];
            int cashbox = 0;
            int point = 0;

            for (int j = 0; j < n; j++)
            {
                sellers[j] = clients[j];
            }
            point = n - 1;

            while (true)
            {
                for (int j = 0; j < n; j++)
                {
                    sellers[j] -= 1;
                    cashbox += 1;
                    if (sellers[j] == 0)
                    {
                        if (point >= clients.Length - 1 && sellers.Max() == 0)
                        {
                            while (cashbox % n != 0)
                            {
                                cashbox += 1;
                            }
                            Console.WriteLine("Clients = {0}", string.Join(", ", clients));
                            Console.WriteLine("Sellers = {0}", n);
                            Console.WriteLine("Result = {0}\n", (cashbox / n));
                            return 0;
                        }
                        else if (point < clients.Length - 1)
                        {
                            point += 1;
                            sellers[j] = clients[point];
                        }
                    }
                }
            }
        }

    }
}