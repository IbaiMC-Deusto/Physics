using UnityEngine;

public class DinamicMovement : MonoBehaviour
{
    public int JumpForce;
    public int velocity;

    void Update()
    {
        Movement();
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
}
