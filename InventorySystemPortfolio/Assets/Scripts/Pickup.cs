using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemButton;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.Debug.Log("test");
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }

    }

}
