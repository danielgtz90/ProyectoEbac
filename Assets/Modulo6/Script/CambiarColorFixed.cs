using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorFixed : MonoBehaviour
{
    public GameObject prefabEsfera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Se crea color Random de esfera desde FixedUpdate");
        //prefabEsfera.GetComponent()<MeshRenderer>();        //renderizamos objeto
        var meshRendererMaterial = prefabEsfera.GetComponent<MeshRenderer>().material; //agregamos material
        meshRendererMaterial.color = new Color(UnityEngine.Random.value,UnityEngine.Random.value,UnityEngine.Random.value); //agregamos color
    }
}
