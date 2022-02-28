using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    //List<int> valoresRandom(int tamaño, int rangoInf, int rangoSup);
    // Start is called before the first frame update
    private Stack<string> despensa = new Stack<string>();
    private Queue<string> despensa1 = new Queue<string>();
    void Start()
    {
        miLista(5,3,10);
        segundoEjercicio(5,50);
        
        despensa.Push("leche");
        despensa.Push("pan");
        despensa.Push("jamon");
        despensa.Push("huevos");
        despensa.Push("carne");
        
        Debug.Log(despensa.Peek());
        despensa1.Enqueue(despensa.Peek()); 
        despensa.Pop();
        
        Debug.Log(despensa.Peek());
        despensa1.Enqueue(despensa.Peek());
        despensa.Pop();

        Debug.Log(despensa.Peek());
        despensa1.Enqueue(despensa.Peek());
        despensa.Pop();
        
        Debug.Log(despensa.Peek());
        despensa1.Enqueue(despensa.Peek());
        despensa.Pop();
        
        Debug.Log(despensa.Peek());
        despensa1.Enqueue(despensa.Peek());
        despensa.Pop();
        foreach (string elemento in despensa1)
        {
            Debug.Log(elemento);
        }
        
        
        
    }

    public void miLista(int tamaño, int rangoInf, int rangoSup)
    {
        List<int> numerosAleatorios = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            numerosAleatorios.Add(Random.Range(rangoInf, rangoSup));
        }

        foreach (var numero in numerosAleatorios)
        {
            Debug.Log(numero);
        }
    }

    public void segundoEjercicio(int rangoInf, int rangoSup)
    {
        int[] segundoPunto = new int[10];
        for (int i = 0; i < segundoPunto.Length; i++)
        {
            segundoPunto[i] = Random.Range(rangoInf, rangoSup);
        }

        var listaOrdenada = segundoPunto.OrderBy(p => p).Reverse().ToList();

        foreach (var ordenados in listaOrdenada)
        {
            Debug.LogWarning(ordenados);
        }

        var hashdeLista = listaOrdenada.Distinct();
        
        foreach (var hashi in hashdeLista)
        {
            Debug.LogError(hashi);
        }
    }

   


}
