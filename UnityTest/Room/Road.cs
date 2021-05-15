using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    class Road
    {

        public Road()
        {
            Console.WriteLine("Вы находитесь на локации Дорога\nВаши действия");
            Console.WriteLine("1. Поговорить с бродягой");
            Console.WriteLine("2. Осмотреть окрестности");
        }

        public void GetActionOneInfo()
        {
            Console.WriteLine("Получаете от бродяги 50 монет и медальон");
        }

        public int GetActionMoney() //метод для выдачи 50 монет
        {
            return 50;
        }

        public string GetActionLocket() // метод для выдачи медальона
        {
            return "медальон";
        }

        public void GetActionOneTwoInfo()
        {
            Console.WriteLine("Бродяга молчит");
        }

        public void GetActionTwoInfo()
        {
            Console.WriteLine("Вы осматриваете местность");
        }

    }
}
