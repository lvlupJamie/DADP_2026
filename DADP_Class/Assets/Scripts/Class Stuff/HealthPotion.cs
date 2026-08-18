using UnityEngine;

public class HealthPotion : Potions
{
    public void RestoreHealth()
    {
        Debug.Log("Your health is restored");
    }

    public void Start()
    {
        Drink();
        RestoreHealth();
    }
}
