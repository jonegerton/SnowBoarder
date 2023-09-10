using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float ReloadDelay = 1f;
    [SerializeField] ParticleSystem CrashEffect;

    void OnTriggerEnter2D(Collider2D other) {
        
        Debug.Log("CrashDetector.OnTriggerEnter2D");

        if (other.tag == "Snow") {
            CrashEffect.Play();
            Invoke("ReloadScene", ReloadDelay);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
