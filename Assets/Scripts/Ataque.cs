using UnityEngine;
using System.Collections;

public class Ataque : MonoBehaviour {

    public Transform proyectil;
    public Transform posicionInicialBala;
    public int velocidadDisparo = 3;

    public void Atacar()
    {
        Transform bala = (Transform)Instantiate(proyectil, posicionInicialBala.position, transform.rotation);
        bala.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000 * velocidadDisparo);
        Destroy(bala.gameObject, 2);
    }
}
