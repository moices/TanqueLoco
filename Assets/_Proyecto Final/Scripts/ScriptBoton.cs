using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScriptBoton : MonoBehaviour {

public void CargarScenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }

public void Salir()
    {
        Application.Quit();
    }

}
