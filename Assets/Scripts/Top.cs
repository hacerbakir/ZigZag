using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    bool isBlue;
    bool isRed;
    bool isGreen;
    void Start()
    {
        isBlue=false;
        isRed=false;
        isGreen = false;
    }

    private void OnTriggerStay(Collider collision)
    {
       
        if (collision.gameObject.tag == "blue" && !isBlue)
        {

            isBlue = true;
            isGreen = false;
            isRed = false;
            TopHareketi.hız = 3;
            
        }
        else if (collision.gameObject.tag == "red" && !isRed)
        {
            isBlue = false;
            isGreen = false;
            isRed = true;
            TopHareketi.kontrol = false;
           
        }
        else if (collision.gameObject.tag == "green" && !isGreen)
        {
            isBlue = false;
            isGreen = true;
            isRed = false;
            TopHareketi.hız = 2;
            
        }
    }
    
}
