using System;

namespace Humans
{
    public class Human
    {
        // Fields and Props for Human
        // public string Name {get; set; }
        // public int Strength;

        // public int StrengthProp 
        // {
        //     get
        //     {
        //         return 100;
        //     }
        //     set
        //     {
        //         Strength = value;
        //     }
        // }
        // public int Intelligence;
        // public int IntelligenceProp 
        // {
        //     get
        //     {
        //         return 100;
        //     }
        //     set
        //     {
        //         Intelligence = value;
        //     }
        // }
        // public int Dexterity;
        // public int DexterityProp 
        // {
        //     get
        //     {
        //         return 100;
        //     }
        //     set
        //     {
        //         Dexterity = value;
        //     }
        // }
        // Fields and Props for Human with settable props
        public string Name {get; set; }
        public int Strength {get; set; }

        public int Intelligence {get; set; }
        public int Dexterity {get; set; }

        private int health;

         
        // add a public "getter" property to access health
        public int Health
        {
            get { return 100; }
            set { health = value; }
        } 
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values

        // Default
        public Human () { }

        // Params
        // public Human (string name)
        // {
        //     Name = name;
        //     Strength = StrengthProp;
        //     Intelligence = IntelligenceProp;
        //     Dexterity = DexterityProp;
        //     health = Health;
        // }

        public override string ToString()
        {
            return @$"
            Name:         {Name}
            Strength:     {Strength}
            Intelligence: {Intelligence}
            Dexterity:    {Dexterity}
            Health:       {Health}
            ";
        }
        // Add a constructor to assign custom values to all fields
        public Human (string name, int strength, int intelligence, int dexterity)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = Health;
        }
         
        // Build Attack method
        public int Attack(Human target)
        {
            target.Health -= (Strength * 5);
            System.Console.WriteLine($"{target.Name} was attacked by {Name} for {Strength * 5}. {target.Name} has {target.health} remaining.");
            return target.health;
        }
        
    }
}