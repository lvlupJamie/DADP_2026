using NUnit.Framework;
using UnityEngine;

public class Polymorphism : MonoBehaviour
{
    public class Character : MonoBehaviour
    {
        public string Name; //string property
        public Character(string name) //character construct
        {
            Name = name;
        }
    }

    public class Warrior : Character
    {
        public string Weapon;
        public Warrior(string name, string weapon) : base(name)
        {
            Weapon = weapon;
        }
    }

    public class Action : MonoBehaviour
    { 
        void Start()
        {
            Warrior warrior = gameObject.AddComponent<Warrior>();

            warrior.Name = "John Adventurer";
            warrior.Weapon = "Sword";

            Debug.Log(warrior.Name);
            Debug.Log(warrior.Weapon);
        }
    }
    
    public class Weapon : MonoBehaviour
    {
        public string Name;
        public int Damage;

        public virtual void Attack()
        {
            Debug.Log("The Weapon is attacking");
        }
    }

    public class Bow : Weapon
    {
        public override void Attack()
        {
            Debug.Log("The bow is attacking with an arrow shot");
        }
    }

    public class Sword : Weapon
    {
        public override void Attack()
        {
            Debug.Log("The sword is attacking with a slash");
        }
    }

    public class WeaponAction : MonoBehaviour
    {
        void Start()
        {
            //create an instance of sword and bow on this game object
            Sword sword = gameObject.AddComponent<Sword>();
            Bow bow = gameObject.AddComponent<Bow>();

         //create a list to collect all the weapons
            //List<Weapon> weapons = new List<Weapon> { sword, bow };

         //CAll Attack() on each weapon
            //foreach (Weapon weapon in weapons)
            //{
            //    weapon.Attack();
            //}
        }
    }
}
