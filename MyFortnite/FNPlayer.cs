using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortnite
{
    class FNPlayer
    {
        public string equipedWeapon;
        public double hitPoints;
        public double shield;

        public FNPlayer()
        {
            equipedWeapon = "picareta";
            hitPoints = 100;
            shield = 0;
        }

        public FNPlayer(string equipedWeapon, double hitPoints, double shield)
        {
            this.equipedWeapon = equipedWeapon;
            this.hitPoints = hitPoints;
            this.shield = shield;
        }

        public void Attack(FNPlayer enemy)
        {
            enemy.TakeDamage(10);
        }

        void Move()
        {

        }

        void EquipWeapon()
        {

        }

        public void TakeDamage(double damage)
        {
            if(shield > 0)
            {
                shield -= damage;
                if (shield < 0)
                {
                    shield = 0;
                }
            } else
            {
                hitPoints -= damage;
                if(hitPoints <= 0)
                {
                    //Die();
                }
            }
        }
    }
}
