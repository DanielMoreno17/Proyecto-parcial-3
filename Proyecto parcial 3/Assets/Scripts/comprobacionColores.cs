using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class comprobacionColores : MonoBehaviour
{
    Control_Colors c_colors;

    private void Start()
    {
        c_colors = GameObject.Find("ManagerColores").GetComponent<Control_Colors>();
    }
        
    private void OnTriggerStay(Collider other)
    {
        if (gameObject.name== "rojo" && other.gameObject.name == "rojoT")
        {
            c_colors.rojo = true;
        }

        if (gameObject.name == "naranja" && other.gameObject.name == "naranjaT")
        {
            c_colors.naranja = true;
        }

        if (gameObject.name == "amarillo" && other.gameObject.name == "amarilloT")
        {
            c_colors.amarillo = true;
        }

        if (gameObject.name == "verde" && other.gameObject.name == "verdeT")
        {
            c_colors.verde = true;
        }

        if (gameObject.name == "cian" && other.gameObject.name == "cianT")
        {
            c_colors.cian = true;
        }

        if (gameObject.name == "morado" && other.gameObject.name == "moradoT")
        {
            c_colors.morado = true;
        }

        if (gameObject.name == "fuxia" && other.gameObject.name == "fuxiaT")
        {
            c_colors.fuxia = true;
        }
      
    }

    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "rojo" && other.gameObject.name == "rojoT")
        {
            c_colors.rojo = false;
        }

        if (gameObject.name == "naranja" && other.gameObject.name == "naranjaT")
        {
            c_colors.naranja = false;
        }

        if (gameObject.name == "amarillo" && other.gameObject.name == "amarilloT")
        {
            c_colors.amarillo = false;
        }

        if (gameObject.name == "verde" && other.gameObject.name == "verdeT")
        {
            c_colors.verde = false;
        }

        if (gameObject.name == "cian" && other.gameObject.name == "cianT")
        {
            c_colors.cian = false;
        }

        if (gameObject.name == "morado" && other.gameObject.name == "moradoT")
        {
            c_colors.morado = false;
        }

        if (gameObject.name == "fuxia" && other.gameObject.name == "fuxiaT")
        {
            c_colors.fuxia = false;
        }
    }
}
