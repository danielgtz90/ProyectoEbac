using UnityEngine;

public class CambiarColorUpdate : MonoBehaviour

{
    public GameObject prefabCapsula;
    private Renderer Colores;

    // Start is called before the first frame update
    private void Start()
    {
        Colores = prefabCapsula.GetComponent<Renderer>();
    }


    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Se crea color Random de Capsula desde Update");

        Colores.material.color = new Color(UnityEngine.Random.value,UnityEngine.Random.value,UnityEngine.Random.value);
    }
}