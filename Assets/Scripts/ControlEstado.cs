using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlEstado : MonoBehaviour {

    private int puntos;
    private int puntosvida;
    public Text puntuacion;
    public Text vida;

	// Use this for initialization
	void Start () {
        puntos = 0;
        puntosvida = 10;
	}

    void Update ()
    {
        if (puntosvida < 1) 
        {
            
            print("Game OVER !!!");
        }
    }
	
    public void SumaPuntos (int p)
    {
        puntos += p;
        puntuacion.text = puntos.ToString();
    }

    public void RestaPuntos(int p)
    {
        puntos -= p;
        puntuacion.text = puntos.ToString();
    }

    public void SumaVida(int p)
    {
        puntosvida += p;
        vida.text = puntosvida.ToString();
    }

    public void RestaVida(int p)
    {
        puntosvida -= p;
        vida.text = puntosvida.ToString();
    }
}
