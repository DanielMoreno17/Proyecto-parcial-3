using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RespawnPollito : MonoBehaviour
{
    [SerializeField] GameObject respawnPollito;
    [SerializeField] TextMeshProUGUI texto;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10)
        {
            transform.position = respawnPollito.transform.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {  
        if (other.CompareTag("incorrecto"))
        {
            transform.position = respawnPollito.transform.position;
            Debug.Log("El pollito tocó una respuesta incorrecta");
        }

        if (other.name == "Final")
        {
            texto.SetText("Has reunido al pollito y a su mamá, has ganado!");
        }
        
    }
}
