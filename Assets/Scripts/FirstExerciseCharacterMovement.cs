using UnityEngine;

public class FirstExerciseCharacterMovement : MonoBehaviour
{
    public float speed = 1.0f;

    public float damage = 0;  // Exercise 3

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacterByInput();
    }

    private void MoveCharacterByInput()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontalMovement, 0, verticalMovement);

        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
