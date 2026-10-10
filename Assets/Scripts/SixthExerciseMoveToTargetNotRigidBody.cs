using UnityEngine;

public class SixthExerciseMoveToTargetNotRigidBody : MonoBehaviour
{
    public string targetTag = "target";
    public string obstacleTag = "obstacle";
    public Material hitMaterial;
    public float speed = 3.0f;

    private Transform target;
    private Collider obstacleCollider;
    private Collider sphereCollider;

    private bool obstacleReached = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);
        GameObject obstacleObject = GameObject.FindGameObjectWithTag(obstacleTag);
        if (targetObject != null)
        {
            target = targetObject.transform;
        }
        if (obstacleObject != null)
        {
            obstacleCollider = obstacleObject.GetComponent<Collider>();
        }

        sphereCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
             return;   
        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (!obstacleReached && obstacleCollider != null && sphereCollider.bounds.Intersects(obstacleCollider.bounds))
        {
            obstacleCollider.GetComponent<Renderer>().material = hitMaterial;
            obstacleReached = true;
        }
    }
}
