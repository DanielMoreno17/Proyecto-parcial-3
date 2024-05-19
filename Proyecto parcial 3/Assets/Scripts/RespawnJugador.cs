using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnJugador : MonoBehaviour
{
    [SerializeField] GameObject respawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > -5)
        {
            transform.position = respawn.transform.position;
        }
    }
  
}
