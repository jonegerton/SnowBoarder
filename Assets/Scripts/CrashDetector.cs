using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;

    [SerializeField] AudioSource crashSound;

    private bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D other) {
        
        Debug.Log("CrashDetector.OnTriggerEnter2D");

        if (other.tag == "Snow" && !hasCrashed) {
            hasCrashed = true;
            crashEffect.Play();
            crashSound.Play();
            Invoke("ReloadScene", reloadDelay);
            FindObjectOfType<PlayerController>().DisableControls();
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
