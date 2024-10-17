using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj03_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog pochi = new Dog();

            //最初の空腹状態を表示してみる
            Console.WriteLine("空腹状態：{0}", pochi.IsHungry());

            //pochiにエサをあげる
            pochi.Eat();
            Console.WriteLine("空腹状態：{0}", pochi.IsHungry());

            //pochiを走らせる
            pochi.Run();
            Console.WriteLine("空腹状態：{0}", pochi.IsHungry());

            //一時停止
            Console.ReadLine();
        }
    }
}
