using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicMovement : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float jumpForce = 5f;

    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("vertical");

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized;



    }
}
