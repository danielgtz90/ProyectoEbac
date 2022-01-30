using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class CambiarColorAwake : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject prefabCube;
    void Awake()
    {
        Debug.Log("Se crea color Random de cubo desde Awake");
        //prefabCube.AddComponent<MeshRenderer>();        //renderizamos objeto
        var meshRendererMaterial = prefabCube.GetComponent<MeshRenderer>().material; //agregamos material
        meshRendererMaterial.color = new Color(UnityEngine.Random.value,UnityEngine.Random.value,UnityEngine.Random.value);; //agregamos color
        
    }
    
    // Update is called once per frame
    void Start()
    {
        

    }
    
}
