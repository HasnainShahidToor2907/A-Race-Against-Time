using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carstability : MonoBehaviour
{
    public GameObject mycar;
    float mycarx, mycary, mycarz;
    // Start is called before the first frame update
    void Start()
    {
      
      
    }

    // Update is called once per frame
    void Update()
    {
        mycarx = mycar.transform.eulerAngles.x;
        mycary = mycar.transform.eulerAngles.y;
        mycarz = mycar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(mycarx - mycarx, mycary, mycarz - mycarz);

    }
}
