using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;

    [SerializeField] AudioSource finishSound;

    void OnTriggerEnter2D(Collider2D other) {
        
        Debug.Log("FinishLine.OnTriggerEnter2D");

        if (other.tag == "Player") {
            finishEffect.Play();
            finishSound.Play();
            Invoke("ReloadScene", reloadDelay);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
