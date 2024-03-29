﻿/*
 * Zechariah Burrus
 * Assignment 6
 * Game manager for scenes and pausing
 */

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager> {
    public static GameManager instance;
    public int score;
    public GameObject pauseMenu;

    //Variable to keep track of what level we are on
    private string CurrentLevelName = string.Empty;

/*    #region This code makes this class a Singleton
    private void Awake() {
        if (instance == null) {
            instance = this;
            //Make sure this gamemanager persists across scenes
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a second instance of singleton Game Manager.");
        }
    }
    #endregion
*/

    //Methods to load and unload scenes
    public void LoadLevel(string levelName) {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if(ao == null) {
            Debug.LogError("[GameManager] Unable to load level " + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }

    public void UnloadLevel(string levelName) {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null) {
            Debug.LogError("[GameManager] Unable to unload level " + levelName);
            return;
        }
    }

    public void UnloadCurrentLevel() {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if (ao == null) {
            Debug.LogError("[GameManager] Unable to unload level " + CurrentLevelName);
            return;
        }
    }

    public void Pause() {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void UnPause() {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.P)) {
            Pause();
        }
    }
}
