using UnityEngine;
using System.Collections;

public class PuertaPasillo : MonoBehaviour {

    public Transform miEnemigo;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Ataque script = miEnemigo.GetComponent<Ataque>();
            script.Atacar();
            
        }
    }
}
