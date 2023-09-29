using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupitems : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter (Collider other)
   {
    PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
    if (playerInventory != null)
    {
        playerInventory.ItemsCollected();
        gameObject.SetActive(false);
    }
   }
}
