using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCanvas : MonoBehaviour
{
    public Canvas nextCanvas;
    public Canvas currentCanvas;

    void Start()
    {
        nextCanvas.enabled = false;
    }
    public void SwitchScreens()
    {
        currentCanvas.enabled = false;
        nextCanvas.enabled = true;
    }
}
