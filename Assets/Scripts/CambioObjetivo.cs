using UnityEngine;
using System.Collections;

public class CambioObjetivo : MonoBehaviour {

    public Transform nuevoObjetivo;
    public Transform miEnemigo;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == miEnemigo.gameObject)
        {
            MovimientoEnemigo script = other.gameObject.GetComponent<MovimientoEnemigo>();
            if(!script.getPersiguiendo())
                script.cambiarObjetivo(nuevoObjetivo);
        }

    }

}
