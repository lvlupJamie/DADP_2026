using UnityEngine;

public class Potions : MonoBehaviour
{
    public string potionName;
    public int potency;
    public float volume;

    public void Drink()
    {
        Debug.Log("Name: " + potionName + ". Potency: " + potency + ". Volume: " + volume);
    }
}
