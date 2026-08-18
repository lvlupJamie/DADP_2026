using UnityEngine;

public class Inheritance : MonoBehaviour
{
    public class Cat : Inheritance
    {
        public string Name;
        public int age;

        public void CatMeow()
        {
            Debug.Log("The cat meows");
        }
    }

    //Each of the child classes can technically go into a new script however I am lazy and don't want to do that
    public class Siamese : Cat
    { 
        public void ClimbTree()
        {
            Debug.Log(name + ", the Siamese cat, climbs the tree");
        }
    }

    public class Tabby : Cat
    {
        public void PurrLoudly()
        {
            Debug.Log(name + ", the Tabby cat, purrs loudly");
        }
    }


    public class Enemy : Inheritance
    {
        public int health;
        public int damage;

        public void TakeDamage(int amount)
        {
            health -= amount;
        }
    }

    public class Orc : Enemy 
    { 
        public void Serve()
        {
            Debug.Log("Who do you serve?");
            Debug.Log("SARUMAN!");
        }
    }

    public class Goblin : Enemy
    {
        public void Mind()
        {
            Debug.Log("Mind Goblin deez nuts LMAOO");
        }
    }

}
