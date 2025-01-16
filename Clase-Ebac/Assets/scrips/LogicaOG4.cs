using UnityEngine;

public class LogicaOG5 : MonoBehaviour
{
    public GameObject prefabOG5;

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
        if ((colorblanco && colornegro) ||(!colorblanco && !colornegro))
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
