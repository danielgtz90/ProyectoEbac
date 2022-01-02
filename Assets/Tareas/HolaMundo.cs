using System;
using UnityEngine;

namespace Tareas
{
    public class HolaMundo : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            print("Hola Mundo");
            Debug.Log("Algo Pasó");
            Debug.LogWarning("Hay una Alvertencia");
            Debug.LogError("Hay un fallo");
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void FixedUpdate()
        {
            Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
        }

        private void LateUpdate()
        {
            Debug.Log("Hola desde Late Update");
        }

        private void OnEnable()
        {
            Debug.LogWarning("Algo se ha Habilitado");
        }

        private void OnDisable()
        {
            Debug.LogWarning("Algo se Ha deshabilitado");
        }
    }
}
