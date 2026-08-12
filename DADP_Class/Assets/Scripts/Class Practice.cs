using UnityEngine;
using UnityEngine.Rendering;

public class ClassPractice : MonoBehaviour
{
    public class Animal
    {
        private int legs;
        private int arms;
        private string species;

        public Animal()
        {
            Debug.Log("Animal Created");
        }

        public Animal(int animalLegs, int animalArms, string AnimalSpecies)
        {
            species = AnimalSpecies;
            legs = animalLegs;
            arms = animalArms;
        }
    }

    public class callAnimal
    { 
        void Start()
        {
            Animal Dog = new Animal(4, 0, "Dog");
        }
    }

    public class Zombie
    {
        private int arms;
        private int legs;
        private string name;

        public Zombie(int zomArms, int zomLegs, string zomName)
        {
            arms = zomArms;
            legs = zomLegs; 
            name = zomName;
        }

        public void setLegs(int numLegs)
        {
            legs = numLegs;
        }

        public int getLegs()
        {
            return legs;
        }

        public int getArms()
        {
            return arms;
        }
    }

    public class callZombie
    {
        void strt()
        {
            Zombie myZombie = new Zombie(1, 2, "Chuck");

            myZombie.getArms();
            myZombie.getLegs();
        }
    }
}
