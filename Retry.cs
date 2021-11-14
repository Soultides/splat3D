using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public static void LoadLastScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("_last_scene_"));
    }
}
