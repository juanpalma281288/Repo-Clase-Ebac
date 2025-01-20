using UnityEngine;

public class LogicaOG5 : MonoBehaviour
{
    public GameObject prefabOG5;

    public bool colorblanco;

    public LogicaOG3 logica3;
    public LogicaOG4 logica4;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    
    
    {
      

        if ((!logica3.colorblanco && logica4.colorblanco) || (logica3.colorblanco && !logica4.colorblanco))
        {
            Color c = new Color(1.0f, 1.0f, 1.0f);
            prefabOG5.GetComponent<MeshRenderer>().material.color = c;
            
           
        }
        else
        {
            Color c = new Color(0f, 0f, 0f);
            prefabOG5.GetComponent<MeshRenderer>().material.color = c;

            

        }
    }
}
