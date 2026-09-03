using UnityEngine;
using static Interfaces;

public class InterfaceEnemies : MonoBehaviour
{
    public class Orc : MonoBehaviour, IDamagable
    {
        int health = 100;
        public void TakeDamage (int amount)
        {
            health -= amount; 
            Debug.Log("Damage is done to the Orc");
        }
    }

    public class Zombie : MonoBehaviour, IDamagable
    {
        int health = 100;
        public void TakeDamage(int amount)
        {
            health -= amount;
            Debug.Log("Damage is done to the Zombie");
        }
    }

}
