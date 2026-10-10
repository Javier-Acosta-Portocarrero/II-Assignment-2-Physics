using UnityEngine;

public class ForthExerciseCollectible : MonoBehaviour
{
    public string playerTag = "main-character";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            Debug.Log("Collectible picked up.");
            Destroy(gameObject);
        }
    }
}
