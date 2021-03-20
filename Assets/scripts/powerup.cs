using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public GameObject PickupEffect;
    public float MainTimer;
    Renderer rand;

    public void Start()
    {
        rand = GetComponent<Renderer>();
        rand.enabled = true;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
        
    }
    
    void Pickup(Collider Player)
    {

        Instantiate(PickupEffect, transform.position, transform.rotation);
        Hiding();
        Destroy(this);

    }
    void Hiding()
    {
        rand.enabled=false;
    }
}    
