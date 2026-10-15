using UnityEngine;

public class FirstExerciseCharacterMovement : MonoBehaviour
{
    public float speed = 1.0f;

    public float damage = 0;  // Exercise 3
    private Rigidbody internalRigidBody;
    private float horizontalMovement = 0;
    private float verticalMovement = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        internalRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        MoveCharacterByInput();
    }

    private void MoveCharacterByInput()
    {
        Vector3 movementDirection = horizontalMovement * transform.right + verticalMovement * transform.forward;
        Vector3 movement = movementDirection * speed * Time.fixedDeltaTime;

        internalRigidBody.MovePosition(internalRigidBody.position + movement);
    }
}
