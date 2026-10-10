using UnityEngine;

public class ThirdExerciseChangeColorInZone : MonoBehaviour
{
    public string targetTag = "main-character";
    private Color originalColor = Color.white;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.CompareTag(targetTag)) 
        {
            originalColor = otherObject.GetComponent<Renderer>().material.color;
            otherObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    void OnTriggerExit(Collider otherObject)
    {
        if (otherObject.CompareTag(targetTag)) 
        {
            otherObject.GetComponent<Renderer>().material.color = originalColor;
        }
    }
}
