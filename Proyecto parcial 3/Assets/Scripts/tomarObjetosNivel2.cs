using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomarObjetosNivel2 : MonoBehaviour
{
    bool objCerca = false;
    GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (objCerca)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                objeto.transform.SetParent(transform);
                Rigidbody rb = objeto.GetComponent<Rigidbody>();
                rb.isKinematic = true;
                rb.useGravity = false;
                objeto.transform.position = transform.position;
                objeto.transform.rotation = transform.rotation;

            }
            if (Input.GetKeyUp(KeyCode.E))
            {

                objeto.transform.SetParent(null);
                Rigidbody rb = objeto.GetComponent<Rigidbody>();
                rb.isKinematic = false;
                rb.useGravity = true;
                //objeto.transform.position = transform.position;
                //objeto.transform.rotation = transform.rotation;

            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("colores"))
        {
            objCerca = true;
            objeto = obj;


        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.CompareTag("colores"))
        {
            objCerca = false;
            objeto = null;

        }
    }

}
