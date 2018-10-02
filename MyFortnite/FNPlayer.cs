using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortnite
{
    class FNPlayer
    {
        private string equipedWeapon;
        private double hitPoints;
        private double shield;

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

        public double GetShield()
        {
            return shield;
        }

        public void SetShield(double shield)
        {
            this.shield = shield;
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
