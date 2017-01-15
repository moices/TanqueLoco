using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    public Material redMaterial;
    public Material greenMaterial;
    public Material yellowMaterial;

	// Use this for initialization
	void Start () {
	   
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            ChangeMaterial(greenMaterial);
        }
        else if (Input.GetKey(KeyCode.Y))
        {
            ChangeMaterial(yellowMaterial);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            ChangeMaterial(redMaterial);
        }
    }

    private void ChangeMaterial (Material newMaterial)
    {
        gameObject.GetComponent<Renderer>().material = newMaterial;
    }
         
}
