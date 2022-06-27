using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketi : MonoBehaviour
{
    Vector3 yön;
    public static float hız;
    public ZeminSpawner ZeminSpawnerScript;
    public static bool düştü_mü;
    public static bool kontrol;


    void Start()
    {

        yön = Vector3.forward;
        düştü_mü = false;
        hız = 2f;
        kontrol = true;

    }


    void Update()
    {

        if (transform.position.y <= 0.5f)
        {
            düştü_mü = true;
        }

        if (düştü_mü == true)
        {
            return;
        }

        if (kontrol == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                if (yön.x == 0)
                {
                    yön = Vector3.left;
                }
                else
                {
                    yön = Vector3.forward;
                }

            }


        }
        else
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (yön.x == 0)
                {
                    yön = Vector3.left;
                }
                else
                {
                    yön = Vector3.forward;
                }
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * hız;
        transform.position += hareket;
    }


    //temas kesilidkten sonra
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("box"))
        {
            Skor.skor++;
            collision.gameObject.AddComponent<Rigidbody>();
            ZeminSpawnerScript.Zemin_olustur();
            StartCoroutine(ZeminiSil(collision.gameObject));
        }
    }


    //zaman içeren kodlar için ienumerator tanımlanır
    IEnumerator ZeminiSil(GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);
    }
}
