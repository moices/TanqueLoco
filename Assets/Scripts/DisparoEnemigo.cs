using UnityEngine;
using System.Collections;

public class DisparoEnemigo : MonoBehaviour {

    public Transform proyectil;
    public Transform posicionInicialBala;
    public int velocidadDisparo = 2;

    private MovimientoEnemigo scriptMovimiento;

    private float tiempoEntreDisparos = 2;
    private float tiempoUltimoDisparo = 0;

    // Use this for initialization
    void Start () {
        scriptMovimiento = GetComponent<MovimientoEnemigo>();
	}
	
	// Update is called once per frame
	void Update () {
        if (scriptMovimiento.getPersiguiendo())
        {
            if (Time.time - tiempoUltimoDisparo > tiempoEntreDisparos)
            {
                Atacar();
                tiempoUltimoDisparo = Time.time;
            }
        }
	}

    void Atacar()
    {
        Transform bala = (Transform)Instantiate(proyectil, posicionInicialBala.position, transform.rotation);
        bala.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000 * velocidadDisparo);
        Destroy(bala.gameObject, 3);
    }
}
