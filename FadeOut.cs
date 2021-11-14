using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    Color objectColor;
    Image m_Image;

    public float timer;

    private void Start()
    {
        //sets the alpha to zero
        m_Image = GetComponent<Image>();
        m_Image.CrossFadeAlpha(0, 0f, false);

    }
    public void Inked()
    {
        //chnages the alpha to max, then fades it over the next two seconds
        m_Image.CrossFadeAlpha(1, 0f, false);
        //Debug.Log("Inked");

        //Debug.Log("Fade");
        m_Image.CrossFadeAlpha(0, 2.0f, false);

    }
}
