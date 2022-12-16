using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static string pickUpKey = "n";
    public static string haveFriend = "n";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Adding magnitude with direction 
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal")*4, Input.GetAxis("Vertical")*4);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Key")
        {
            pickUpKey = "y"; 
        }
    }
}
