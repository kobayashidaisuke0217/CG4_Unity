using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float moveSpeed;
    public float jumpSpeed; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameClerScript.isClear)
        {
            Vector3 a;
            a.x = 0; a.y=0; a.z = 0;
            rb.velocity = a;
            rb.isKinematic = true;
            return;
        }
        Vector3 v = rb.velocity;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v.x=moveSpeed;  
        }
        
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            v.x = -moveSpeed;
        }
        else
        {
            v.x = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            v.y = jumpSpeed;
        }
        rb.velocity = v;
    }
}
