using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class GameCharacter
    {
        protected string Name { get; set; }
        protected int Strength { get; set; }
        protected int Intelligence { get; set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public virtual string Play()
        {
            return $"Name: {Name}| Str: {Strength}| Int: {Intelligence}";
        }
    }

    class Warrior : GameCharacter
    {
        public string weaponType { get; set; }
        public Warrior(string name, int strength, int intelligence, string weapon): base(name, strength, intelligence)
        {
            weaponType = weapon;
        }
        public override string Play()
        {
            return $"{base.Play()}| Weapon: {weaponType}";
        }
    }

    class MagicUsingCharacter: GameCharacter
    {
        public int magicEnergy { get; set; }
        public MagicUsingCharacter(string name, int strength, int intelligence, int ENERGY): base(name, strength, intelligence)
        {
            magicEnergy = ENERGY;
        }
        public override string Play()
        {
            return $"{base.Play()}| MgcEng: {magicEnergy}";
        }
    }

    class Wizard : MagicUsingCharacter
    {
        public int spellNumber { get; set; }

        public Wizard(string name, int strength, int intelligence, int ENERGY, int spellnum ): base(name, strength,intelligence, ENERGY)
        {
            spellNumber = spellnum;
        }
        public override string Play()
        {
            return $"{base.Play()}| SpellNumber: {spellNumber}";
        }
    }
}
