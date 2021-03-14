using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class timer : MonoBehaviour
{
    float startingtime;
    float currenttime;
    public UnityEngine.UI.Text screentext;
    // Start is called before the first frame update
    void Start()
    {
        startingtime = 5.0f;
        currenttime = startingtime;
        
    }

    // Update is called once per frame
    void Update()
    {   
        currenttime = currenttime - 1 * Time.deltaTime;
        screentext.text = currenttime.ToString("00");
        if (currenttime <=0)  
        {
            screentext.text = "GO!";
        }
       // Debug.Log(currenttime);
    }
}
