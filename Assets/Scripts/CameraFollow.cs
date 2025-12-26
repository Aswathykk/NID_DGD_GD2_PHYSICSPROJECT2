using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // we want a target object
    public GameObject targetObject;
    public Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = targetObject.transform.position + offset;
    }
}
