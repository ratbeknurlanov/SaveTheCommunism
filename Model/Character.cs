﻿using SaveTheCommunism.Utilities;

namespace SaveTheCommunism.Model
{
    public class Character
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public Vector Speed { get; set; }
        public Vector Direction { get; set; }

        public virtual void Hit(Character another)
        {
            another.TakeDamage(Damage);
        }

        private void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}