using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float ReloadDelay = 1f;
    [SerializeField] ParticleSystem FinishEffect;

    void OnTriggerEnter2D(Collider2D other) {
        
        Debug.Log("FinishLine.OnTriggerEnter2D");

        if (other.tag == "Player") {
            FinishEffect.Play();
            Invoke("ReloadScene", ReloadDelay);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
