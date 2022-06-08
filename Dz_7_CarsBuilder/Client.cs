using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Dz_7_CarsBuilder
{
    class Client
    {
        public void Main()
        {
            // Клиентский код создаёт объект-строитель, передаёт его директору,
            // а затем инициирует  процесс построения. Конечный результат
            // извлекается из объекта-строителя.
            var director = new Shop(); 

            int flag = 0;
            while (flag == 0)
            {
                WriteLine("Купить:\n" +
                    "1. Теслу\n" +
                    "2. Ауди\n" +
                    "3. БМВ\n" +
                    "4. Хундай\n" +
                    "5. Выход");

                int choise = Convert.ToInt32(ReadLine());

                switch (choise)
                {
                    case 1:
                        var builder1 = new ConcreteTeslaS();
                        director.Builder = builder1 ;
                         
                        director.buildFullFeaturedProduct();
                        WriteLine(builder1.GetProduct().ListParts()); 
                        break;
                    case 2:
                        var builder2 = new ConcreteAudi3();
                        director.Builder = builder2;
                         
                        director.buildFullFeaturedProduct();
                        WriteLine(builder2.GetProduct().ListParts()); 
                        break;
                    case 3:
                        var builder3 = new ConcreteBMWx4();
                        director.Builder = builder3;
                         
                        director.buildFullFeaturedProduct();
                        WriteLine(builder3.GetProduct().ListParts()); 
                        break;
                    case 4:
                        var builder4 = new ConcreteHundaiGets();
                        director.Builder = builder4;

                        director.buildFullFeaturedProduct();
                        WriteLine(builder4.GetProduct().ListParts());
                        break;
                    case 5: flag++; break;
                    default: flag++; break;
                } 
            } 
        } 
    }
}
