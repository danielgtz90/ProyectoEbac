using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine;

namespace Modulo8.ScriptsModulo8
{
    public class EjerciciosVariablesMod8 : MonoBehaviour
    {
        [SerializeField] private int puntoUnoInt;
        [SerializeField] private float puntoUnoFloat;
        [SerializeField] private float Dato1;
        [SerializeField] private float Dato2;
        [SerializeField] private GameObject cuboMod8;
        [SerializeField] private GameObject esferaMod8;
        enum seleccionPalabra
        {
            Verde,
            Negro,
            Rojo,
            Azul
        }

        // Start is called before the first frame update
        void Start()
        {
            //convertir flotante en entero
            var cambidecolorEsfera = esferaMod8.GetComponent<MeshRenderer>().material;
            float resultado = 0;
            Dato1 = 25.5f;
            Dato2 = 3;
            resultado = (int) (Dato1 / Dato2);
            Debug.Log("El resultado explicito de 25.5/3 es: " + resultado);
            //convetir flotante a string con 4 decimales
            float pi = 3.141692f;
            string pii = pi.ToString("0.0000");
            Debug.Log("se cambia el valor flotante 3.141692 a 4 digitos en formato string:" + pii);
            // Extraer nombre en 3 strings y lista de strings
            string name = "Daniel Gutierrez Calixto";
            string palabra1 = name.Substring(0,6);
            string palabra2 = name.Substring(7,10);
            string palabra3 = name.Substring(17,7);
            Debug.Log("Nombre: " + palabra1);
            Debug.Log("Primer Apellido: " + palabra2);
            Debug.Log("Segundo Apellido: " + palabra3);
            string[] listaNombre = name.Split(' ');
            foreach (var sub in listaNombre)
            {
                Debug.Log($"Lista Nombre split: {sub}");
            }
            // Variables string de miles COMO WARNING
            string numero1 = "1000";
            string numero2 = "1500";
            int numeroParse1 = 0;
            int numeroParse2 = 0;
            int.TryParse(numero1.ToString(), out numeroParse1);
            Debug.LogWarning(numeroParse1);
            int.TryParse(numero2.ToString(), out numeroParse2);
            Debug.LogWarning(numeroParse2);
            int operacion = 0;
            operacion = numeroParse1 + numeroParse2;
            Debug.LogWarning(operacion);
            //
            string nombre = "red";
            int longitud = nombre.Length;
            Debug.Log(longitud);
            switch (longitud)
            {
                case (int) seleccionPalabra.Verde:
                    cambidecolorEsfera.color=Color.green;
                    Debug.Log("El color es verde");
                    break;
                
                case (int) seleccionPalabra.Negro:
                    cambidecolorEsfera.color=Color.black;
                    Debug.Log("El color es negro");
                    break;
                
                case (int) seleccionPalabra.Rojo:
                    cambidecolorEsfera.color=Color.red;
                    Debug.Log("El color es rojo");
                    break;
                
                case (int) seleccionPalabra.Azul:
                    cambidecolorEsfera.color=Color.blue;
                    Debug.Log("El color es azul");
                    break;
                default:
                    Debug.Log("ese color no esta en la lista");
                    break;
            }
            // String con oracion "Hola desde Monterrey!"
            int tamaño;
            string saludo = "Hola desde Monterrey!";
            tamaño = saludo.Length;
            char[] saludos = { };
                
            for (int i=0; i<tamaño; i++)
            {
                //Debug.LogWarning(cual);
                if (i % 2 == 0)
                {
                    Debug.LogWarning("la letra par es: "+ saludo[i]);
                }
            } 
            //
            string ultimo = "Hola desde Monterrey!";
            string remover=ultimo.Remove(0,5);
            Debug.LogWarning("se han removido los primeros 5 caracteres: " + remover);

        }

        // Update is called once per frame
        void Update()
        {
            puntoUnoInt++;
            Debug.Log("El valor entero se esta incrementando cada frame: " + puntoUnoInt);
        
        }

        private void FixedUpdate()
        {
            var cambidecolor = cuboMod8.GetComponent<MeshRenderer>().material;
            puntoUnoFloat = 2.2f;
            puntoUnoFloat *= puntoUnoInt;
            Debug.Log("El valor Float se esta incrementando cada FixedUpdate: " + puntoUnoFloat);
            if(puntoUnoInt % 2 == 0)
            {
                Debug.Log("El resultado es Par y color negro");
                cambidecolor.color= Color.black;

            }
            else
            {
                Debug.Log("El resultado es Non y color blanco");
                cambidecolor.color= Color.white;
            }
        }
    }
}
