using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public GameObject showcase;
    BoxCollider cold;
    public Item item;
    public static bool canPickup;
    public static bool isWeaponAvailable;
    public GameObject player;
    public InventoryObject inventory;

    // Start is called before the first frame update
    void Start()
    {
        isWeaponAvailable = true;
        canPickup = false;
        cold = showcase.GetComponent<BoxCollider>();
        inventory = player.GetComponent<PlayerInventoryManager>().inventory;

        if (inventory == null)
        {
            Debug.LogError("ERROR! Please set an inventory!!!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isWeaponAvailable)
        {
            if (canPickup) 
            {
                if (Input.GetKeyDown("q"))
                {
                    canPickup = false;
                    isWeaponAvailable = false;
                    inventory.AddItem(item, 2);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canPickup = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canPickup = false;    
    }
}
