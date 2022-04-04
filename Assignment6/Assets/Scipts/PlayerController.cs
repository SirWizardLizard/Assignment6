/*
 * Zechariah Burrus
 * Assignment 6
 * Generic player controller
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float turnSpeed;
    public float forwardInput;
    public float horizontalInput;
    public bool gameOver = false;
    public bool tutorial = true;

    public GameObject gameOverText;
    public GameObject tutorialText;

    Scene currentScene;

    void Start() {
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update() {
        if (tutorial && currentScene.name == "Level 1") {
            tutorialText.SetActive(true);
            Time.timeScale = 0f;
            if (Input.GetKeyDown(KeyCode.T)) {
                tutorial = false;
                tutorialText.SetActive(false);
                Time.timeScale = 1f;
            }
        }

        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Move forward with forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Move player left/right with horizontal input
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.R) && gameOver) {
            SceneManager.LoadScene(currentScene.name);
            Time.timeScale = 1f;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("Enemy") && !gameOver) {
            Debug.Log("GAME OVER!");
            gameOver = true;

            Time.timeScale = 0f;
            gameOverText.SetActive(true);
        }
    }
}