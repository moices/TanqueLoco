using UnityEngine;
using System.Collections;

public class MovimientoEnemigo : MonoBehaviour {

    private NavMeshAgent nav;
    public Transform objetivoInicial;
    private Transform objetivoActual;
    public Transform posicionInicial;

    private float distanciaMaxima = 40;

    private bool persiguiendo = false;


	// Use this for initialization
	void Start () {
        objetivoActual = objetivoInicial;
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(objetivoActual.position);

        float distancia = Vector3.Distance(transform.position, posicionInicial.position);

        if (distancia > distanciaMaxima)
        {
            setPersiguiendo(false);
            cambiarObjetivo(objetivoInicial);
        }       
	}

    public void cambiarObjetivo(Transform nuevoObjetivo)
    {
        objetivoActual = nuevoObjetivo;
    }

    public void setPersiguiendo(bool p)
    {
        persiguiendo = p;
    }

    public bool getPersiguiendo()
    {
        return persiguiendo;
    }

}
