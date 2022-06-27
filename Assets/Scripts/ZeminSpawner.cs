using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{
    public GameObject son_zemin;
    private GameObject spawnBox;
    public float spawnDegeri;
    float tutucu;
    public GameObject zemin1;
    public GameObject zemin2;
    public GameObject zemin3;
    int level;

    void Start()
    {
        spawnDegeri = 1;
        level = 10;
        spawnBox = zemin1;

        for (int i = 0; i < 10; i++)
        {
            Zemin_olustur();
        }
    }

    public void Zemin_olustur()
    {
        Vector3 yön;


        if (Skor.skor > level)
        {

            tutucu = Random.Range(0, 6);



            if (tutucu < 3f)
            {
                spawnBox = zemin1;
                level += 10;
            }
            else if (tutucu < 5f)
            {
                spawnBox = zemin2;
                level += 2;
            }
            else
            {
                spawnBox = zemin3;
                level += 2;
            }

        }


        if (Random.Range(0,2) == 0)
        {

            yön = new Vector3(0f, 0f, spawnDegeri);
            
        }else
        {
            yön = new Vector3(-spawnDegeri, 0f, 0f);
        }




        son_zemin = Instantiate(spawnBox, son_zemin.transform.position + yön, son_zemin.transform.rotation);


    }
}
