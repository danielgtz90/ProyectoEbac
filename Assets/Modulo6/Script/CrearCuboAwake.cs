using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


namespace Modulo6.Script
{
    public class CrearCuboAwake : MonoBehaviour
    {
        public GameObject prefabCubo;
        public List<GameObject> listaesferas;
        public float factordeescalamiento;
        public int numEsferas = 0;
       
        // Start is called before the first frame update
        private void Awake()
        {
            listaesferas = new List<GameObject>();
            numEsferas++;
            GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
            tempGameObject.name = "EsferaNumero" + numEsferas;
            Color c = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
            tempGameObject.GetComponent<MeshRenderer>().material.color = c;
            tempGameObject.transform.position = UnityEngine.Random.insideUnitSphere;
            listaesferas.Add(tempGameObject);
            List<GameObject> objetosparaeliminar = new List<GameObject>();
            foreach (GameObject go in listaesferas)

            {
                float scale = go.transform.localScale.x;
                scale *= factordeescalamiento;
                go.transform.localScale=Vector3.one*scale;

                if (scale<=0.5)
                {
                    objetosparaeliminar.Add(go);
                }
            }

            foreach (GameObject go in objetosparaeliminar)
            {
                listaesferas.Remove(go);
                Destroy(go);
            
            }
            
            Debug.Log("Se crea cubo desde Awake");
        }

        
        void Start()
        {
            
        

        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
