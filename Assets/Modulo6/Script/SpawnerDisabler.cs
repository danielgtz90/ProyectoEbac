using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerDisabler : MonoBehaviour
{
    private GameObject objToSpawn;
    private Vector3[] vertices =
    {
        new Vector3(0, 0, 0), //Vertice 0    Puntos en el espacio para dibujar
        new Vector3(1, 0, 0), //Vertice 1
        new Vector3(1, 1, 0), //Vertice 2 
        new Vector3(0, 1, 0), //Vertice 3
        new Vector3(0, 1, 1), //Vertice 4
        new Vector3(1, 1, 1), //Vertice 5
        new Vector3(1, 0, 1), //Vertice 6
        new Vector3(0, 0, 1), //Vertice 7
    };

    private int[] triangulos =
    {
        0, 2, 1, //Cara 1
        0, 3, 2, //Cara 1.1  2 triangulos por cara para formar cuadro 2d
        2, 3, 4, //Cara 2    Cada vector 
        2, 4, 5, //Cara 2.1
        1, 2, 5, //Cara 3
        1, 5, 6, //Cara 3.1
        0, 7, 4, //Cara 4
        0, 4, 3, //Cara 4.1
        5, 4, 7, //Cara 5
        5, 7, 6, //Cara 5.1
        0, 6, 7, //Cara 6
        0, 1, 6, //Cara 6.1

    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnDisable()
    {
        Debug.Log("PrintOnDisable: script was disabled");
    }

    void OnEnable()
    {
        Debug.Log("PrintOnEnable: script was enabled");
        Crearcubo();
    }


       
        
        // Start is called before the first frame update
        void Crearcubo()
        {
            objToSpawn = new GameObject("Cubo en On enable"); // Object to spawn es como aparecer objeto 
            objToSpawn.AddComponent<MeshFilter>();              //agregamos componentes
            var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
            meshFilter.Clear();                                 //Borrar movimientos por frames?    
            meshFilter.vertices = vertices;                     //Asignamos Vertices a variable mesh
            meshFilter.triangles = triangulos;                  //Asignamos Lineas-triangulos
            meshFilter.Optimize();
            meshFilter.RecalculateNormals();                    //
            objToSpawn.AddComponent<BoxCollider>();             //Agregamos Componente
            var boxCollider = objToSpawn.GetComponent<BoxCollider>();
            boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);// movemos de posicion de origen al centro con valores float
            objToSpawn.AddComponent<MeshRenderer>();        //renderizamos objeto
            objToSpawn.AddComponent<Rigidbody>();
            var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material; //agregamos material
            meshRendererMaterial.color = new Color(UnityEngine.Random.value,UnityEngine.Random.value,UnityEngine.Random.value); //agregamos color
            objToSpawn.transform.position = Random.insideUnitCircle; //movemos posicion de cubo


        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
