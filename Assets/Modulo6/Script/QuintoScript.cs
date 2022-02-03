using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuintoScript : MonoBehaviour
{
    public GameObject prefabCapsula;
    public Boolean estado3erScript;
    public Boolean estado4toscript;
    public Boolean state;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        estado3erScript = FindObjectOfType<CambiarColorAwake>().state3;
        Debug.Log("Tenemos el estado de la esfera desde Capsula(1) " + estado3erScript);
        estado4toscript = FindObjectOfType<CuartoScriptOR>().state;
        Debug.Log("Tenemos el estado de la esfera desde capsula(1) " + estado4toscript);
        var meshRendererMaterial = prefabCapsula.GetComponent<MeshRenderer>().material;
        state = estado4toscript && estado3erScript;
        Debug.Log(state);
        
        if (estado4toscript || estado3erScript)
        {
            Debug.Log("El resultado True total en el quinto script");
            meshRendererMaterial.color = Color.white;
           
        }
        else
        {
            Debug.Log("El resultado False total en el quinto script");
            meshRendererMaterial.color = Color.black;
           
        }
    }
}
