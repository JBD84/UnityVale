using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{
    public Transform transformCam;
    public BoxCollider miCollider;
    GameObject[] circulo;
    void Start()
    {
        //  circulo = GameObject.Find("Sphere");
        circulo = GameObject.FindGameObjectsWithTag("Circulo");
        miCollider = gameObject.GetComponent<BoxCollider>();
        miCollider.enabled = false;
        
        foreach( GameObject sphere in circulo) {
            Debug.Log(sphere.name);
        }

        for (int i = 0; i < circulo.Length; i++)
        {
            circulo[i].SetActive(false);
        }
     
     //   Debug.Log(gameObject.transform.position.x);
        Debug.Log(transformCam.position.x);

    }
    void Update()
    {
        
    }
}
