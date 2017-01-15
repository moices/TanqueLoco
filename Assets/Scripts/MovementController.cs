using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{

    private CharacterController controller;
    float velocidadGiro = 2;
    float velocidad = 10;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        float giro = Input.GetAxis("Horizontal") * velocidadGiro;
        transform.Rotate(new Vector3(0, giro, 0));

        Vector3 delante = transform.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical");

        controller.SimpleMove(delante * velocidad);
    }

}