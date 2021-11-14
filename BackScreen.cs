using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackScreen : MonoBehaviour
{
    public Canvas pauseMenu;
    public Canvas currentMenu;

    public void BackaScreen()
    {
        currentMenu.enabled = false;
        pauseMenu.enabled = true;
    }
}
