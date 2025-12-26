using UnityEngine;

// Attach this script to a GameObject to apply force at start
public class applyforce : MonoBehaviour
{
    //references
    private Rigidbody rb;

    public float force;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get references
        rb = GetComponent<Rigidbody>();

        Vector3 forceVector = new Vector3(force, 0, 0);

        //apply a force to the rigidbody in one direction to the ball
        rb.AddForce(forceVector);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
