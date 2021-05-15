using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string flag = "+";
            int crutch = 0;


            // инвентарь и кошелек игрока
            int wallet = 0;
            List<string> inventory = new List<string>();
            int choic;

            Road road = new Road();
            do
            {
                do
                {
                    choic = Convert.ToInt32(Console.ReadLine());
                    if (choic == 1 || choic == 2)
                    {
                        flag = "-";
                        switch (choic)
                        {
                            case 1:
                                if (crutch == 0)
                                {
                                    road.GetActionOneInfo();
                                    wallet += road.GetActionMoney();
                                    inventory.Add(road.GetActionLocket());
                                    crutch++;
                                }
                                else
                                {
                                    road.GetActionOneTwoInfo();
                                }

                                break;

                            case 2:
                                road.GetActionTwoInfo();

                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор! Попробуйте ещё!");
                    }
                }
                while (flag == "+");
                flag = "+";
            }
            while (flag == "+");


            Console.ReadLine();
        }
    }
}
