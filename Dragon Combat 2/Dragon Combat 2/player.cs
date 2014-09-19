using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Combat_2
{
    class player
    {
        public enum AttackType
            Sword = 1,
            Magic,
            Heal
        }

        public int HP;
        public bool IsAlive;

        //constructors
        
        public int DoAttack();
        public AttackType ChooseAttac();
        public void TakeDamage(int damage);


}
