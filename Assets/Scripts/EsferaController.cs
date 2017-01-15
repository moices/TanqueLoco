using UnityEngine;
using System.Collections;

// Notas: 
// 1. Para cambiar el color se puede usar: GetComponent<Renderer>().material.SetColor("_Color", Color.green);
// 2. Para cambiar de Material se puede crear una variable publica y asignarla a material. 
//

public class EsferaController : MonoBehaviour {

    public Material colorEsfera;

    void OnTriggerEnter(Collider other)
    {
        print("colision sin name: "+ other.tag);
        if (other.tag == "Player")
        {
            print("Colision con nombre");
            gameObject.GetComponent<Renderer>().material = colorEsfera;
        }


    }
}
