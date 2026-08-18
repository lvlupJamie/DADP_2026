using UnityEngine;

public class InvisibilityPotion : Potions
{
    public void BecomeInvisible()
    {
        Debug.Log("You become invisible");
    }

    public void Start()
    {
        Drink();
        BecomeInvisible();
    }
}
