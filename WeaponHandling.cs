using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandling : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject weapon;
    public Item weaponItem;

    //Transform[] playerComponents;
    GameObject playerHand;
    void Start()
    {
        playerHand = GameObject.FindGameObjectWithTag("RightHand");
        Debug.Log(weaponItem.description);
    }

    // Update is called once per frame
    void Update()
    {
        if(!PickItem.canPickup && !PickItem.isWeaponAvailable)
        {
            
            if (playerHand != null)
            {
                //object1.transform.parent = object2.transform;
                if (weaponItem.theItem.transform.parent != null)
                {
                    weaponItem.theItem.transform.parent = null;
                }

                weaponItem.theItem.transform.parent = playerHand.transform;

                weaponItem.theItem.transform.position = new Vector3(playerHand.transform.position.x, playerHand.transform.position.y - 0.1f, playerHand.transform.position.z + 0.05f);
                weaponItem.theItem.transform.rotation = Quaternion.Euler(playerHand.transform.rotation.eulerAngles.x + 90, playerHand.transform.rotation.eulerAngles.y, playerHand.transform.rotation.eulerAngles.z);

            }

            //for (int i = 0; i < playerComponents.Length; i++)
            //{
            //    if(playerComponents[i].gameObject.tag == "RightHand")
            //    {
                    //Debug.Log(playerComponents[i]);
            //        playerHand = playerComponents[i];
            //    }

            //}

        }
    }
}
