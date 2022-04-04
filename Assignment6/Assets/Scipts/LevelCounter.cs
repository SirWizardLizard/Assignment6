/*
 * Zechariah Burrus
 * Assignment 6
 * Counts the level the player is on
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour {
    public Text textbox;
    public int levelCounter = 0;

    // Start is called before the first frame update
    void Start() {
        textbox = GetComponent<Text>();
        textbox.text = "Level: " + levelCounter;
    }

    // Update is called once per frame
    void Update() {
        textbox.text = "Level: " + levelCounter;
    }
}
