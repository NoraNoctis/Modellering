using System;

namespace Modellering uppgift
{
    public class Enemy
    {
        public bool isAlive;

        public string Name;
        public int attack1;
        public int attack2;
        public int chargeupp = 1; //byggs upp, if > 5 attack2

        public int defense;
        public int hp;

        public string taunt;

        int callMinion = 3; // används tillsammans med random generator

    }
}
