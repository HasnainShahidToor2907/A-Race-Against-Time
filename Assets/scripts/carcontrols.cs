using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carcontrols : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.75f);// code for going forward
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);// code for going left
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);// code for going right
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -1);// code for going backwards
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0, 2);// code for boosting
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(0, 0, 2.5f);// code for super boosting

        }
        if (transform.position.z > 2344)// code for loop
        {
            Vector3 newposition = new Vector3(transform.position.x,transform.position.y,-2468);
            transform.position = newposition;
        }
    }
}










