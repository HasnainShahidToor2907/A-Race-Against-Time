using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public GameObject PickupEffect;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) ;
        {
            Pickup();
        }
    }
    void Pickup()
    {
        Instantiate(PickupEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}