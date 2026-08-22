using UnityEngine;

[CreateAssetMenu(fileName = "InventorySystem", menuName = "Scriptable Object / Inventory System")]

public class InventorySystem : ScriptableObject
{
    public string itemName;
    [TextArea] public string itemDescription;
    public int itemValue;
}