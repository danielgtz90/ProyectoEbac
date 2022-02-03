using System;
using UnityEngine;

public class CambiarColorUpdate : MonoBehaviour

{
    public GameObject prefabCapsula;
    private Renderer Colores;
    public Boolean valorCapsula;

    // Start is called before the first frame update
    private void Start()
    {
        Colores = prefabCapsula.GetComponent<Renderer>();
        valorCapsula = true;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Debug.Log("Se crea color Random de Capsula desde Update");
        if (valorCapsula == true)
        {
            Debug.Log("True color blanco");
            Colores.material.color = Color.white;
            valorCapsula = false;
        }
        else
        {
            Debug.Log("False color negro");
            Colores.material.color = Color.black;
            valorCapsula = true;
            //Colores.material.color = new Color(UnityEngine.Random.value,UnityEngine.Random.value,UnityEngine.Random.value);
        }
    }
}