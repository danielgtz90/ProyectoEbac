using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorFixed : MonoBehaviour
{
    public GameObject prefabEsfera;
    public Boolean valorEsfera;
    
    // Start is called before the first frame update
    void Start()
    {
        valorEsfera = true;
    }
    void FixedUpdate()
    {
        var meshRendererMaterial = prefabEsfera.GetComponent<MeshRenderer>().material; //agregamos material
        //Debug.Log(valorEsfera);
        if (valorEsfera == true)
        {
            Debug.Log("True color blanco");
            meshRendererMaterial.color = Color.white;
            valorEsfera = false;
        }
        else
        {
            Debug.Log("False color negro");
            meshRendererMaterial.color = Color.black;
            valorEsfera = true;
        }
        //Debug.Log("Se crea color Random de esfera desde FixedUpdate");
        //var meshRendererMaterial = prefabEsfera.GetComponent<MeshRenderer>().material; //agregamos material
        //meshRendererMaterial.color = new Color(UnityEngine.Random.value,UnityEngine.Random.value,UnityEngine.Random.value); //agregamos color
    }
}
