using UnityEngine;

public class LogicaOG3 : MonoBehaviour
{
    public GameObject prefabOG3;

    public bool colorblanco;

    public LogicaOG1 logica1;

    public LogicaOG2 logica2;

    public 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (logica1.colorblanco && logica2.colorblanco )
        {
            Color c = new Color(1.0f, 1.0f, 1.0f);
            prefabOG3.GetComponent<MeshRenderer>().material.color = c;

           
            
        }
        else
        {
            Color c = new Color(0f, 0f, 0f);
            prefabOG3.GetComponent<MeshRenderer>().material.color = c;
            
           
        }
    }
}
