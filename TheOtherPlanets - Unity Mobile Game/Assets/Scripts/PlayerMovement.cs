using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forceStrength;

    
    public void MoveUp()
    {
        //get the rigidbody that we will be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.up * forceStrength);

    }
    public void MoveDown()
    {
        //get the rigidbody that we will be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.down * forceStrength);

    }
    public void MoveLeft()
    {
        //get the rigidbody that we will be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.left * forceStrength);

    }
    public void MoveRight()
    {
        //get the rigidbody that we will be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Move in the correct direction with the set force strength
        ourRigidbody.AddForce(Vector2.right * forceStrength);

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
