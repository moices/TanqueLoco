using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

    private AudioSource audioOrigen;

	// Use this for initialization
	void Start () {
        audioOrigen = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("s") || Input.GetKeyDown("S"))
        {
            if (audioOrigen.isPlaying)
            {
                audioOrigen.Stop();
            } else if (!audioOrigen.isPlaying) {
                audioOrigen.Play();
            }
        }
	}
}
