using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj03_2
{
    internal class Dog
    {
        //状態や属性「データ」・・・フィールド
        private bool hungryState;
        //ふるまい「操作」・・・メソッド
        //コンストラクタ(クラス名 Dog と伊那路名前のメソッド)
        public Dog()
        {
            hungryState = true;//最初はお腹がすいている
        }
        public void Eat()//食べる
        {
            Console.WriteLine("ぱくぱく");
            hungryState = false; //お腹はすいていない
        }

        public void Run()//走る
        {
            Console.WriteLine("わんわんわん");
            hungryState = true;//お腹すいた
        }

        public bool IsHungry()//お腹すいてるか調べる
        {
            return hungryState;
        }
    }
}
