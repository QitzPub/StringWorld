﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enemy
    {
      protected  string name = "ダミー";
        int hp;
       protected int maxHp = 3;
       protected  int attack = 1;

        public bool DeadF;

        public void MakeEnemy()
        {
            Enemy slime = new Slime();
        }

        public void Print()
        {
            Console.WriteLine(name + ":" + hp);
        }


        public void Attack(Player player)
        {
            Console.WriteLine( name + "の攻撃");
            player.Damage(attack);

        }

        public void Damage(int damege)
        {
            hp -= damege;
            Console.WriteLine("{0}に{1}のダメージをあたえた！", name, damege);
            if (hp <= 0)
            {
                DeadF = true;
            }
        }

        public void LevelUp()
        {
            maxHp += 10;
            hp = maxHp;
        }

    }
}
