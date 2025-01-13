using UnityEngine;

public class logcacambiodecolor : MonoBehaviour
{
    public GameObject prefabcubo;
    public GameObject prefabcapsula;
    public GameObject prefabcirculo;
    public bool colornegro;
    public bool colorblanco;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (colorblanco)
        {
            Color c = new Color(1.0f, 1.0f, 1.0f);
            prefabcubo.GetComponent<MeshRenderer>().material.color = c;
        }
        else
        {
            Color c = new Color(0.0f, 0.0f, 0.0f);
            prefabcubo.GetComponent<MeshRenderer>().material.color = c;

        }
        
        
        
       
    }
}
