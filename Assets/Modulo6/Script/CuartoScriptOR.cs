using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuartoScriptOR : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabCube;
    public Boolean estadoEsfera;
    public Boolean estadoCapsula;
    public Boolean state;
    void Awake()
    {
        //Debug.Log("Se crea color Random de cubo desde Awake");
        //prefabCube.AddComponent<MeshRenderer>();        //renderizamos objeto
        //var meshRendererMaterial = prefabCube.GetComponent<MeshRenderer>().material; //agregamos material
        //meshRendererMaterial.color = new Color(UnityEngine.Random.value,UnityEngine.Random.value,UnityEngine.Random.value);; //agregamos color
        
    }
    
    // Update is called once per frame
    void Update()
    { 
        var meshRendererMaterial = prefabCube.GetComponent<MeshRenderer>().material;
        estadoEsfera = FindObjectOfType<CambiarColorFixed>().valorEsfera;
        Debug.Log("Tenemos el estado de la esfera desde Cubo " + estadoEsfera);
        estadoCapsula = FindObjectOfType<CambiarColorUpdate>().valorCapsula;
        Debug.Log("Tenemos el estado de la esfera desde cubo " + estadoCapsula);
        state = estadoCapsula || estadoEsfera;
        Debug.Log(state);
        if (estadoCapsula || estadoEsfera)
        {
            Debug.Log("Usamos OR (1,0 || 0,1) y Color Blanco desde Cubo");
            meshRendererMaterial.color = Color.white;
           
        }
        else
        {
            Debug.Log("Usamos OR (1,1 || 0,0)  y Color Negro desde cubo");
            meshRendererMaterial.color = Color.black;
            //valorCapsula = true;
            //Colores.material.color = new Color(UnityEngine.Random.value,UnityEngine.Random.value,UnityEngine.Random.value);
        }

    }

   
}
