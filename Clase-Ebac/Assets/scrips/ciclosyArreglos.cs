using UnityEngine;

public class ciclosyArreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int size = 10;
        int[] arr1 = new int[size];
        int[] arr2 = new int[size];
        int[] suma = new int[size];


        for (int i = 0; i < size; i++)
        {
            arr1[i] = UnityEngine.Random.Range(0, 101);
            arr2[i] = UnityEngine.Random.Range(0, 101);
        }


        for (int i = 0; i < size; i++)
        {
            suma[i] = arr1[i] + arr2[i];
        }


        Debug.Log("Arreglo 1: " + string.Join(", ", arr1));
        Debug.Log("Arreglo 2: " + string.Join(", ", arr2));
        Debug.Log("suma: " + string.Join(", ", suma));


        string[] frase = new string[6] { "hola", "esta", "es", "la", "clase", "ebac" };
        string resultado = "";

        foreach (string s in frase)
        { resultado += s + " "; }



        Debug.Log(resultado);

        float[,] Matriz1 = {
              {1,2,3},
              {4,5,6}
        };

        float[,] Matriz2 =  {
              {2},
              {4},
              {6}
        };



        float[,] MatrizResultado = new float[2, 1];


        for (int i = 0; i < 2; i++) 
        {
            for (int j = 0; j < 1; j++) 

            {
                MatrizResultado[i, j] = 0;
                for (int k = 0; k < 3; k++) 
                {
                    MatrizResultado[i, j] += Matriz1[i, k] * Matriz2[k, j];
                }
            }
        }

        Debug.Log("Matriz Resultante C:");
        for (int i = 0; i < 2; i++)
        {
            Debug.Log(MatrizResultado[i, 0]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
