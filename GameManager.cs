using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public bool paused = false;

    public Canvas pauseMenu;
    public Canvas settingsMenu;
    public Canvas controlsMenu;

    public GameObject firstPause;
    public GameObject controlPause;
    public GameObject settingPause;

    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlayerPrefs.SetString("_last_scene_", scene.name);
    }
    void Start()
    {
        pauseMenu.enabled = false;
        settingsMenu.enabled = false;
        controlsMenu.enabled = false;
    }
    void Update()
    {
        if (Input.GetButtonDown("Pause Menu") && paused == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Pause();
            //Debug.Log("Pause Game");
        }

    }

    public void Pause()
    {
        paused = true;
        pauseMenu.enabled = true;
        /*
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstPause);
        */
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseMenu.enabled = false;
        settingsMenu.enabled = false;
        controlsMenu.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        //Debug.Log("Resume Game");
        Time.timeScale = 1;
        paused = false;
    }


    public void Settings()
    {
        pauseMenu.enabled = false;
        settingsMenu.enabled = true;
        /*
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(settingPause);
        */
        Debug.Log("Settings");
    }

    public void Controls()
    {
        pauseMenu.enabled = false;
        controlsMenu.enabled = true;
        /*
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(controlPause);
        */
        Debug.Log("Controls");
    }
}
