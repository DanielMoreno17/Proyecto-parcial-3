using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tomarobjetos : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textos; 
    [SerializeField] GameObject respawnPollito;
    [SerializeField] GameObject pollito;
    bool objCerca = false;
    GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("textoInicio");
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
            }
        }

        if (pollito.transform.position.y < -10)
        {
            pollito.transform.position = respawnPollito.transform.position;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("tomable"))
        {
            objCerca = true;
            objeto = obj;
        }

        try
        {
            if (other.CompareTag("incorrecto"))
            {
                objeto.transform.SetParent(null);
                Rigidbody rb = objeto.GetComponent<Rigidbody>();
                rb.isKinematic = false;
                rb.useGravity = true;
                pollito.transform.position = respawnPollito.transform.position;
            }
        } catch (Exception e)
        {
            Debug.Log(e.ToString());
        }

        if (other.name == "Final")
        {
            StartCoroutine("cambiarE");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.CompareTag("tomable"))
        {
            objCerca = false;
            objeto = null;

        }
    }

    IEnumerator textoInicio()
    {
        textos.SetText("Lleva al pollito con su mama al final de los obstaculos");
        yield return new WaitForSeconds(4f);
        textos.SetText("");
    }

    IEnumerator cambiarE()
    {  
        textos.SetText("Has reunido al pollito y a su mamá, has ganado!");
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("principal");
    }

}