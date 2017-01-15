using UnityEngine;
using System.Collections;

public class ControladorDisparo : MonoBehaviour {

    public Transform proyectil;
    public Transform posicionInicial;
    private float potencia = 2500;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform bala = (Transform) Instantiate(proyectil, posicionInicial.position, transform.rotation);
            bala.GetComponent<Rigidbody>().AddForce(transform.forward * potencia);
            Destroy(bala.gameObject, 2);

        }
	}
}
