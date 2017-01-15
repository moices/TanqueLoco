using UnityEngine;
using System.Collections;

public class ColisionController : MonoBehaviour {

    public Transform posicionInicial;

void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = posicionInicial.position;
        }
        

    }
}
