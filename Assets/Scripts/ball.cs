using TMPro;
using UnityEngine;

public class ball : MonoBehaviour
{
     //references
    private Rigidbody ballRigidBody;
    private int Scoreball;
    public float forceB;
    public GameObject textbox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         ballRigidBody = GetComponent<Rigidbody>();
         Scoreball = 0;
        forceB = Random.Range(-5f, 5f);
        //get references
       

        Vector3 forceVector = new Vector3(forceB, 0, 0);

        //apply a force to the rigidbody in one direction to the ball
        // ONE-TIME random impulse
        ballRigidBody.AddForce(forceVector, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        if(Input.GetKey(KeyCode.A))
        {
        
            // Debug.Log("Pressed A");
            // //Move the Player
           //transform.position = new Vector3(transform.position.x-0.1f, transform.position.y, transform.position.z);
            ballRigidBody.AddForce(Vector3.left * 10f);
           
            
        } 
          if(Input.GetKey(KeyCode.D))
        {
        
            // Debug.Log("Pressed D ");
            // //Move the Player
           //transform.position = new Vector3(transform.position.x+0.1f, transform.position.y, transform.position.z);
          ballRigidBody.AddForce(Vector3.right * 10f);
            
        }
        if(Input.GetKey(KeyCode.W))
        {
        
            // Debug.Log("Pressed A");
            // //Move the Player
           //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+0.1f);
           ballRigidBody.AddForce(Vector3.forward * 10f);
            
        } 
          if(Input.GetKey(KeyCode.S))
        {
        
            // Debug.Log("Pressed D ");
            // //Move the Player
           //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-0.1f);
          ballRigidBody.AddForce(Vector3.back * 10f);
            
        } 
        
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("gold"))
        {
            Destroy(other.gameObject); // destroy gold, not the ball
            Scoreball++;
            textbox.GetComponent<TMP_Text>().text = "Score: " + Scoreball;
        }
    }
}
