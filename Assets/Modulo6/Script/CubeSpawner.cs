using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        numEsferas++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabEsfera);
        tempGameObject.name = "EsferaNumero" + numEsferas;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
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
}
