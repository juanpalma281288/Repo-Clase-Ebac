using UnityEngine;

public class ejersiciosVariableModulo8 : MonoBehaviour
{
    public int variable1= 1;
    public float variable2 = 3.2f;
    private float num1 = 11.3f;
    private float num2 = 3.7f;

    public GameObject cilindroModulo8;
    public GameObject GOmodulo8;

    public string palabraparacambiodecolor = "inpar";

    float numfloat = 3.141592f;
    string textonumfloat;

   











    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float rersult = num1 / num2;
        Debug.Log("el resultado como float es " + rersult);
        int intresultado = (int)rersult;
        Debug.Log("El resultado como estero es " + intresultado);
        int numrandom = Random.Range(1, 11);

        if (numrandom % 2 == 0)
        {
            Color c = new Color(3f, 1f, 3f);
            cilindroModulo8.GetComponent<MeshRenderer>().material.color = c;
        }
        else
        {
            Color c = new Color(0.0f, 0.0f, 0.0f);
            cilindroModulo8.GetComponent<MeshRenderer>().material.color = c;
        }

        Debug.LogWarning("el numero es " + numrandom);


        textonumfloat=numfloat.ToString("F4");
        Debug.Log(textonumfloat);

        string nombreCompleto = "Juan Palma Rodriguez";

        
        int espacio1 = nombreCompleto.IndexOf(" ");
        int espacio2 = nombreCompleto.LastIndexOf(" ");

        
        string nombre = nombreCompleto.Substring(0, espacio1);
        string primerapellido = nombreCompleto.Substring(espacio1 + 1, espacio2 - espacio1 - 1);
        string apellido = nombreCompleto.Substring(espacio2 + 1);

        
        Debug.Log("Nombre: " + nombre);
        Debug.Log("Segundo Nombre: " + primerapellido);
        Debug.Log("Apellido: " + apellido);

        string valorString1 = "1500";
        string valorString2 = "3800";


        int valor1, valor2;


        
        int.TryParse(valorString1, out valor1);
        int.TryParse(valorString2, out valor2);

        int sumadeinteros = valor1 + valor2;


        Debug.LogWarning("La suma de valor1 y valor2 es : " + sumadeinteros);


        string palabra = "TareaModulo8";
        string resultado="";

       
        if (0 % 2 == 0) resultado += palabra[0];
        if (2 % 2 == 0) resultado += palabra[2];
        if (4 % 2 == 0) resultado += palabra[4];
        if (6 % 2 == 0) resultado += palabra[6];
        if (8 % 2 == 0) resultado += palabra[8];
        if (10 % 2 == 0) resultado += palabra[10];

        
        Debug.Log( resultado);

        string texto = "Tarea Modulo 8 EBAC";

        
        string resultadopalabra = (texto.Length > 5)
            ? texto.Substring(5)
            : "";

        Debug.LogWarning("Texto original: " + texto);
        Debug.LogWarning("Texto después de eliminar los primeros 5 caracteres: " + resultadopalabra);





    }

    // Update is called once per frame
    private void Update()
    {
        variable1*= 2;
        Debug.Log(variable1);

        switch (palabraparacambiodecolor)
        {
            case "par":
                GOmodulo8.GetComponent<Renderer>().material.color = Color.blue;
                break;

            case "inpar":
                GOmodulo8.GetComponent<Renderer>().material.color = Color.red;
                break;
            default:
                Debug.LogWarning("valor no reconocido usa par o inpar")
                    ; break;



                
                



        }


    }


    private void FixedUpdate()
    {
        variable2*= 1.8f;
        Debug.Log(variable2);
    }





}
