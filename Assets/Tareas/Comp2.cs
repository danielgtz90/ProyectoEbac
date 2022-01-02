using System;
using UnityEngine;

namespace Tarea
{
    public class Comp2 : MonoBehaviour
    {
        private void Awake()
        {
            
        }

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(Comp1.miObjeto.name);
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
