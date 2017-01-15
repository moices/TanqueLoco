using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class KeyboardController : MonoBehaviour {
    void Update() { 
        if (Input.GetKey(KeyCode.V)) {
            SceneManager.LoadScene("SceneTexto");
        }
    }

}
