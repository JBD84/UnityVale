using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
   void Awake()
    {
        Debug.Log("HOLA AWAKE");

    }
    private void OnEnable()
    {
        Debug.Log("On OnEnable");

    }
    void Start()
    {
        Debug.Log("HOLA Start");
    }

    void Update()
    {
     //   Debug.Log("HOLA update");

    }
    void OnDisable()
    {
        Debug.Log("On Disable");
    }

  
    void OnMouseEnter()
    {
        Debug.Log("On Mouse Enter");
    }
}

