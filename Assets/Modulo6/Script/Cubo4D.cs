using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Modulo6.Script
{
    public class Cubo4D : MonoBehaviour
    {
        GameObject objToSpawn;

        private Vector3[] vertices =
        {
            new Vector3(0, 0, 0), //Vertice 0    Puntos en el espacio para dibujar
            new Vector3(4, 0, 0), //Vertice 1
            new Vector3(4, 0, 4), //Vertice 2 
            new Vector3(0, 0, 4), //Vertice 3
            new Vector3(4, 4, 0), //Vertice 4
            new Vector3(0, 4, 0), //Vertice 5
            new Vector3(0, 4, 4), //Vertice 6
            new Vector3(4, 4, 4), //Vertice 7
            new Vector3(1, 1, 1), //Vertice 8    
            new Vector3(3, 1, 1), //Vertice 9
            new Vector3(1, 1, 3), //Vertice 10 
            new Vector3(3, 1, 3), //Vertice 11
            new Vector3(1, 3, 1), //Vertice 12
            new Vector3(3, 3, 1), //Vertice 13
            new Vector3(3, 3, 3), //Vertice 14
            new Vector3(1, 3, 3), //Vertice 15
        };

        private int[] triangulos =
        {
            1, 9, 0, //Cara 1
            0, 9, 8, //Cara 1.1  2 triangulos por cara para formar cuadro 2d
            1, 9, 4, //Cara 2    Cada vector 
            4, 13, 9, //Cara 2.1
            0, 8, 5, //Cara 3
            5, 12, 8, //Cara 3.1
            4, 13, 5, //Cara 4
            5, 12, 13, //Cara 4.1
            0, 8, 3, //Cara 5
            3, 10, 8, //Cara 5.1
            3, 10, 11, //Cara 6
            11, 2, 3, //Cara 6.1
            2, 11, 1, //Cara 7
            1, 9, 11, //Cara 7.1  2 triangulos por cara para formar cuadro 2d
            5, 12, 4, //Cara 8    Cada vector 
            4, 12, 13, //Cara 8.1
            4, 13, 14, //Cara 9
            14, 4, 7, //Cara 9.1
            2, 11, 14, //Cara 10
            14, 2, 7, //Cara 10.1
            6, 15, 12, //Cara 11
            12, 5, 6, //Cara 11.1
            3, 6, 15, //Cara 12
            15, 10, 3, //Cara 12.1
            6, 15, 7, //Cara 13
            7, 14, 15, //Cara 13.1

        };
        
        // Start is called before the first frame update
        void Start()
        {
            objToSpawn = new GameObject("Mi primer cubo en 4D"); // Object to spawn es como aparecer objeto 
            objToSpawn.AddComponent<MeshFilter>();              //agregamos componentes
            var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
            meshFilter.Clear();                                 //Borrar movimientos por frames?    
            meshFilter.vertices = vertices;                     //Asignamos Vertices a variable mesh
            meshFilter.triangles = triangulos;                  //Asignamos Lineas-triangulos
            meshFilter.Optimize();
            meshFilter.RecalculateNormals();                    //
            objToSpawn.AddComponent<BoxCollider>();             //Agregamos Componente
            var boxCollider = objToSpawn.GetComponent<BoxCollider>();
            boxCollider.center = new Vector3(2, 2, 2);// movemos de posicion de origen al centro con valores float
            objToSpawn.AddComponent<MeshRenderer>();        //renderizamos objeto
            var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material; //agregamos material
            meshRendererMaterial.color = Color.gray; //agregamos color
            objToSpawn.transform.position = Vector3.one; //movemos posicion de cubo


        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
