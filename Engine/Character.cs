using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Character: IEntity
    {
        public int _attack { get; set; } = 0;
        public double _attackChance { get; set; } = 0;
        public int _defence { get; set; } = 0;
        public double _defenceChance { get; set; } = 0;
        public int _health { get; set;} = 0;
        public int _Strength { get; } = 0;
        public Inventory _charInventory { get; set; }
        Random rnd = new Random();
       

        public Character(int attack,int[] attChance , int defence, int[] defChance, int health, int Strength)
        {
            _attack = attack;
            _attackChance = (double)attChance[0]/attChance[1];
            _defence = defence;
            _defenceChance = (double)defChance[0]/defChance[1];
            _health = health;
            _Strength = Strength;           
        }

        public abstract string EntityName();
        public abstract string SpecialRaceAbility();
        public virtual void PerformTimeMod()
        {

        }
        
        public bool AttackSuccess()
        {
           
            bool Success = false;

            if (rnd.NextDouble() <= _attackChance)
             Success = true;

            return Success;
        }

        public bool DefenseSucess()
        {
            bool Success = false;

            if (rnd.NextDouble() <= _defenceChance)
                Success = true;

            return Success;
        }

        public bool IsAlive()
        {
            bool alive= true;

            if (_health == 0)
                alive = false;

            return alive;

        }

        public void Attack(Character character)
        {
            
            character._health= character._health - (_attack - character._defence);

            if (character._health < 0)
                character._health = 0;

        }

       
    }
}