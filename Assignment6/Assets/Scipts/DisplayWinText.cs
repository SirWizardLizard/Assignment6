/*
 * Zechariah Burrus
 * Assignment 6
 * Displays the win text when the player wins and lets them go to the next level
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayWinText : MonoBehaviour {
    public GameObject winText;
    public bool hasWon = false;


    private void Update() {
        if (Input.GetKeyDown(KeyCode.C) && hasWon) {
            loadNextScene();
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            winText.SetActive(true);
            hasWon = true;
        }
    }

    private void loadNextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}