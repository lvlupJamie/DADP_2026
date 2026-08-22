using UnityEngine;

namespace MyGame.Characters
{
    public class Namespaces : MonoBehaviour
    {
        public class Hero
        {
            int health = 100;

            public void printHealth()
            {
                Debug.Log(health);
            }
        }

        /*In new script
        public class Enemy
        {
            int damage = 25;

            public void printDamage()
            {
                Debug.Log(damage);
            }
        }
        */
    }
}

