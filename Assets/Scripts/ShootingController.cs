using UnityEngine;
using System.Collections;

public class ShootingController : MonoBehaviour {

    public Transform proyectil;
    public Transform posicionInicialBala;
    public int velocidadDisparo = 2;

    private AudioSource audio_disparo;

	// Use this for initialization
	void Start () {
        audio_disparo = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audio_disparo.Play();
            Transform bala = (Transform)Instantiate(proyectil, posicionInicialBala.position, transform.rotation);
            bala.tag = "Player";
            bala.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000 * velocidadDisparo);
            Destroy(bala.gameObject, 5);
        }
	}
}
