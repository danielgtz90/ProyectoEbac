using System.Linq;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace Modulo9
{
    public class EjerciciosDeCiclosyArreglos : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int[] primerNumero = new int[6];
            int[] segundoNumero = new int[6];
            int[] resultadoArreglos = new int[6];
            string[] oracion = new string[8] {"Este","es","el","modulo","9","del", "curso", "EBAC."};
            //Arreglos unidimencionales y suma
            for (int i = 0; i<6;i++)
            {
                int j = Random.Range(1, 20);
                primerNumero[i] = j+1;
                Debug.LogWarning(i + " Valor del primer array: " + primerNumero[i]);
                int l = Random.Range(1, 20);
                segundoNumero[i] = l+1;
                Debug.LogWarning(i + " Valor del segundo array: " + segundoNumero[i]);
            }
          
            for (int r = 0; r<6;r++)
            {
                resultadoArreglos[r] = primerNumero[r] + segundoNumero[r];
                Debug.LogWarning(r + " Valor de la operación lineal: " + resultadoArreglos[r]);
            }
            // Arreglo de strings, se concatenan para formar oracion 
            string hola = null;

            foreach (string ebac in oracion)
            {
                hola += ebac + " ";
            }
            Debug.Log(hola);
            
            //Arreglos Bidimensionales
            int[,] miMatriz2D = new int[2, 3] {{2, 4, 1}, 
                                               {7, 9, 3}};
            int[,] unidemensional = new int [3,1] {{3},
                                                   {1},
                                                   {10}};
            int[,] miMatriz3 = new int[2,1];

            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= miMatriz2D.Rank; j++)
                {
                    miMatriz3[i,0] += miMatriz2D[i, j] * unidemensional[j,0];
                }
                Debug.Log( "Valor " + i +",0 : " + miMatriz3[i,0]);
            }
            
            
            
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
