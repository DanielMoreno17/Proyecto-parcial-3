using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class panelManager : MonoBehaviour
{
    [SerializeField] GameObject panelMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void estadoPanel(bool estado)
    {
        panelMenu.SetActive(estado);
    }
}
