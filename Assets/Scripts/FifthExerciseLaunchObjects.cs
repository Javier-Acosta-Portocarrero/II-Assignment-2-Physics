using UnityEngine;

public class FifthExerciseLaunchObjects : MonoBehaviour
{
    public float force = 20.0f;
    private Rigidbody rb;
    private bool launchInputGiven = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            launchInputGiven = true;
        }
    }

    void FixedUpdate()
    {
        if (launchInputGiven)
        {
            rb.AddForce(transform.forward * force, ForceMode.Impulse);
            launchInputGiven = false;
        }
    }
}
