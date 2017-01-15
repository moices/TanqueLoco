using UnityEngine;
using System.Collections;

public class DetectarPlayer : MonoBehaviour {

    public Transform miEnemigo;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MovimientoEnemigo script = miEnemigo.GetComponent<MovimientoEnemigo>();
            script.setPersiguiendo(true);
            script.cambiarObjetivo(other.transform);
        }
    }
}
