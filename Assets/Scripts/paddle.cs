using UnityEngine;

public class paddle : MonoBehaviour
{
    private Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 forceToAdd = new Vector3(0,0,0);
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
        
            // Debug.Log("Pressed A");
            // //Move the Player
           //  transform.position = new Vector3(transform.position.x-0.1f, transform.position.y, transform.position.z);
            forceToAdd = Vector3.left;
            
        } 
          if(Input.GetKey(KeyCode.RightArrow))
        {
        
            // Debug.Log("Pressed D ");
            // //Move the Player
           // transform.position = new Vector3(transform.position.x+0.1f, transform.position.y, transform.position.z);
          forceToAdd = Vector3.right;
            
        } 
        Debug.Log("Force to add: " + forceToAdd);

        rigidbody.AddForce(forceToAdd);
    }
}
