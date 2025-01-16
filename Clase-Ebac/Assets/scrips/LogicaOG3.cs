using UnityEngine;

public class LogicaOG3 : MonoBehaviour
{
    public GameObject prefabOG3;

    public bool colornegro;
    public bool colorblanco;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colorblanco = true;
        colornegro = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (colorblanco && !colornegro)
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
