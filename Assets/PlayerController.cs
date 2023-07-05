using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rbJumper;
    bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (canJump)
            {
                rbJumper.AddForce(new Vector2() { x = 0, y = 300 });
                canJump = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log(collisionInfo.gameObject.name);
        Debug.Log(canJump);
        if (collisionInfo.gameObject.name.Equals("Square"))
        {
            canJump = true;
        }
    }

}
