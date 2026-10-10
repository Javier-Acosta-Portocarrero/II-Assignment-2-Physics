using UnityEngine;

public class ThirdExerciseChangeDamageInZone : MonoBehaviour
{
    public string targetTag = "main-character";
    private float originalDamage = 0.0f;

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
            originalDamage = otherObject.GetComponent<FirstExerciseCharacterMovement>().damage;
            otherObject.GetComponent<FirstExerciseCharacterMovement>().damage = 10;
        }
    }

    void OnTriggerExit(Collider otherObject)
    {
        if (otherObject.CompareTag(targetTag)) 
        {
            otherObject.GetComponent<FirstExerciseCharacterMovement>().damage = originalDamage;
        }
    }
}
