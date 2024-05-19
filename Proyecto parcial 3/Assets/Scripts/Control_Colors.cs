using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Control_Colors : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoFin;
    GameManager gameManager;
    public bool rojo, naranja, amarillo, verde, cian, morado, fuxia;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Color rojo: " + rojo);

        Debug.Log("Color naranja: " + naranja);

        Debug.Log("Color amarillo: " + amarillo);

        Debug.Log("Color verde: " + verde);

        Debug.Log("Color cian: " + cian);

        Debug.Log("Color morado: " + morado);

        Debug.Log("Color fuxia: " + fuxia);



        if ((rojo && naranja && amarillo && verde && cian && morado && fuxia) == true)
        {
            StartCoroutine("ganar");
        }
    }
    IEnumerator ganar()
    {
        textoFin.SetText("Has acomodado los colores correctamente!");
        yield return new WaitForSeconds(4);
        gameManager.cambiarEscena("principal");
    }
}
