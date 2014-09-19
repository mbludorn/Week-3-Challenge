using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Combat_2
{
    class Enemy
    {
        //properties
        public string Name { get; set; }
        public int HP { get; set; }
        public bool IsAlive {get};

        //constructors
        public Enemy (string Name, int Health)
        {
            this.Name = Name;
            this.HP = Health;
        }

        public int DoAttack();
        public void TakeDamage(int damage);

    }
}
