using UnityEngine;
using System.Collections;

public class ImpactoBala : MonoBehaviour {

    private GameObject estado;

    void Start()
    {
        estado = GameObject.Find("Estado");
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Enemy")
        {
            // print("gameObject: "+gameObject.tag);
            estado.GetComponent<ControlEstado>().SumaPuntos(1);
        }

        if (other.tag == "Player")
        {
           estado.GetComponent<ControlEstado>().RestaVida(1);
        }

        
    }
}
