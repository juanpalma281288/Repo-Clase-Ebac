using UnityEngine;

public class logicaGOModulo8 : MonoBehaviour
{
    public GameObject cilindroModulo8;
    public bool colorblanco;
    
    LogicaOG1 logica1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colorblanco = !colorblanco;

        if (colorblanco)
        {
            Color c = new Color(1.0f, 1.0f, 1.0f);
            cilindroModulo8.GetComponent<MeshRenderer>().material.color = c;
        }
        else
        {
            Color c = new Color(0f, 0f, 0f);
            cilindroModulo8.GetComponent<MeshRenderer>().material.color = c;

        }
    }
}
