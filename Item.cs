using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Medicine,
    Utility,
    Default
}
[CreateAssetMenu(fileName = "New Item", menuName = "Generate Item/Create", order = 1)]
public class Item : ScriptableObject
{
    public string nam;
    public GameObject theItem;
    public ItemType type;
    //public string surname;
    [TextArea(15, 20)]
    public string description;


}
