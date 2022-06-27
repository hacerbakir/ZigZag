using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKontrol : MonoBehaviour
{
    public Transform topKonum;
    Vector3 fark;

    void Start()
    {

        fark = transform.position - topKonum.position;


    }


    void Update()
    {
        if (TopHareketi.düştü_mü == false)
        {
            transform.position = topKonum.position + fark; 
        }
    }
}
