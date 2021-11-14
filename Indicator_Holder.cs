using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator_Holder : MonoBehaviour
{
    public GameObject prefabIndicator;
    public RectTransform rectTransform;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateIndicator()
    {
        //Instantiate(prefabIndicator, rectTransform.position);
    }
}
