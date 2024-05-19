using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;

public class GameManager : MonoBehaviour
{
    private GameObject gameManager;
    

    // Start is called before the first frame update
    void Start()
    {
        //se asocia la variable local con el gameObject en la jerarquia de objetos
        gameManager = GameObject.Find("GameManager");
        //se le dice que no se destruya entre escenas
        DontDestroyOnLoad(gameObject);
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Cargando1")
        {
            StartCoroutine(CambiarNivel1());
        } else if (scene.name == "CargandoInicio")
        {
            StartCoroutine(CambiarInicio());
        }else if(scene.name == "Cargando2")
        {
            StartCoroutine(CambiarNivel2());
        }else if (scene.name == "Cargando3")
        {
            StartCoroutine(CambiarNivel3());
        } else if (scene.name == "Cargando4")
        {
            StartCoroutine(CambiarNivel4());
        }
        else if (scene.name == "Cargando5")
        {
            StartCoroutine(CambiarNivel5());
        }
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void cambiarEscena(string nombreEscena)//recibe un nombre de escena a la cual se queire ir 
    {
        //te lleva a la escena con la que anteriormente se especificó
        SceneManager.LoadScene(nombreEscena);
    }

    IEnumerator CambiarNivel1()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Nivel1");
    }
    IEnumerator CambiarNivel2()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Nivel2");
    }

    IEnumerator CambiarNivel3()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Nivel3");
    }

    IEnumerator CambiarNivel4()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Nivel4");
    }

    IEnumerator CambiarNivel5()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Nivel5");
    }

    IEnumerator CambiarInicio()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Inicio");
    }



}
