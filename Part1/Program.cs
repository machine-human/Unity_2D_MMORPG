using System;

namespace Part1
{

    // 객체는 속성과 기능으로 분류 가능

    // Knight
    // 속성 : hp, attack, pos
    // 기능 : Move, Attack, Die

    class Knight
    {
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    struct Mage
    {
        public int hp;
        public int attack;


        class Program
        {

            static void KillMage(Mage mage)
            {
                mage.hp = 0;
            }

            static void KillKnight(Knight knight)
            {
                knight.hp = 0;
            }

            static void Main(string[] args)
            {

                Mage mage;
                mage.hp = 100;
                mage.attack = 50;
                KillMage(mage);

                Knight knight = new Knight();
                knight.hp = 100;
                knight.attack = 10;
                KillKnight(knight);
            }
        }
    }
}
