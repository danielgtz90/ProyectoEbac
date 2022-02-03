using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerDisabler : MonoBehaviour
{
    public GameObject PrefabEsfera;
    public List<GameObject> listaesferas;
    public float factordeescalamiento;
    public int numEsferas = 0;

    // Start is called before the first frame update
    void Start()
    {
        listaesferas = new List<GameObject>();
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
    void Crearcubo()
        {
            
            numEsferas++;
            GameObject tempGameObject = Instantiate<GameObject>(PrefabEsfera);
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

        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
