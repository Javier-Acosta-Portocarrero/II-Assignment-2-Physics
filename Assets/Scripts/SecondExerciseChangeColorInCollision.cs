using UnityEngine;

public class SecondExerciseChangeColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " ha colisionado con " + collision.gameObject.name);
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
