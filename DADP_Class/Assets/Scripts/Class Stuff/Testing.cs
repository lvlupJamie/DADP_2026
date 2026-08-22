using MyGame.Characters;
using UnityEngine;
using static MyGame.Characters.Namespaces;

namespace MyGame.Characters
{
    public class Testing : MonoBehaviour
    {
        public Hero myHero;
    }

}

public class Testing : MonoBehaviour
{
    //public PotionData potion;
    public InventorySystem item;

    void Start()
    {
        //Debug.Log("Potion: " + potion.potionName + " heals for " + potion.healAmount);
        Debug.Log(item.itemName + item.itemDescription + item.itemValue);
    }
}
