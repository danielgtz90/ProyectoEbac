using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosSpawnUpdate : MonoBehaviour
{
    public GameObject PrefabCube;
    public List<GameObject> listacubos;
    public float factordeescalamiento;
    public int numCubos = 0;
    // Start is called before the first frame update
    void Start()
    {
        listacubos = new List<GameObject>();
        Debug.Log("Se generan cubos desde Update");
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        tempGameObject.name = "Cubo Numero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = new Vector3(-5, 5, 0);
        listacubos.Add(tempGameObject);
        List<GameObject> objetosparaeliminar = new List<GameObject>();
        foreach (GameObject go in listacubos)

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
            listacubos.Remove(go);
            Destroy(go);
            
        }

    }
}
