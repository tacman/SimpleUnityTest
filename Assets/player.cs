using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public float speed = 0.1f;
    private Vector3 moveVec;
    private Rigidbody rb;
    public void OnMove(InputValue input)
    {
        Vector2 inputVec = input.Get<Vector2>();

        moveVec = new Vector3(inputVec.x, 0, inputVec.y);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + moveVec * speed);
        
        
    }
}
