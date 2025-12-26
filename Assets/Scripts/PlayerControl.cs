using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rb;

    public float sizeStep = 0.5f;
    public float spinSpeed = 5f;
    public float minSize = 0.5f;
    public float maxSize = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartSpinning();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.localScale.x < maxSize)
            {
                transform.localScale += Vector3.one * sizeStep;
            }
        }

        
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.localScale.x > minSize)
            {
                transform.localScale -= Vector3.one * sizeStep;
            }
        }

       
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSpinning();
        }

        
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartSpinning();
        }
    }

    void StartSpinning()
    {
        rb.angularVelocity = Vector3.up * spinSpeed;
    }

    void StopSpinning()
    {
        rb.angularVelocity = Vector3.zero;
    }
}
