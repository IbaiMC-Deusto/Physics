using System;
using Unity.VisualScripting;
using UnityEngine;

public class DinamicMovement : MonoBehaviour
{
    public int JumpForce;
    public int velocity;
    private bool canJump = true;

    void Update()
    {
        Movement();
    }

    private void FixedUpdate()
    {
        Jump();
    }

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.back * velocity;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.forward * velocity;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.left * velocity;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.right * velocity;
        }
    }

    void Jump()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVector = Vector3.up * JumpForce;
            this.GetComponent<Rigidbody>().AddForce(jumpVector);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            canJump = false;
        }
    }
}
