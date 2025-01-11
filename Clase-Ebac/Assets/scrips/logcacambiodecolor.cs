using UnityEngine;

public class logcacambiodecolor : MonoBehaviour
{
    public GameObject prefabcubo;
    public GameObject prefabcapsula;
    public GameObject prefabcirculo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        prefabcirculo.GetComponent<MeshRenderer>().material.color = c;
    }

    void Start()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        prefabcapsula.GetComponent<MeshRenderer>().material.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        prefabcubo.GetComponent<MeshRenderer>().material.color = c;
    }
}
