using TMPro;
using UnityEngine;

public class oncollisionscript : MonoBehaviour
{
    private int numberOfBounces;
    public GameObject textbox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numberOfBounces = 0;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("paddle"))
        {
        
        Debug.Log("Collided with the paddle ");
        numberOfBounces++;
        Debug.Log("Number of bounces: " + numberOfBounces);

        textbox.GetComponent<TMP_Text>().text = "Bounces:" + numberOfBounces;
        }
        // else
        // {
        //     Destroy(gameObject);
        // }
        // if(other.gameObject.CompareTag("ground"))
        // {
        //    Destroy(gameObject);
        // }
    }
}
