using UnityEngine;

public class scripMensajes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
       // Debug.Log("hola mundo desde awake");

    }

    void Start()
    {
        Debug.LogError("mundo desde start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("hola mundo desde Update");
    }


    private void OnEnable()
    {
        Debug.Log("hola mundo desde onEnable");
    }

    private void OnDisable()
    {
        Debug.LogError("hola mundo desde OnDisable");
    }
}
