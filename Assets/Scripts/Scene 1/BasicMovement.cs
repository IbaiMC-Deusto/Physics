using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.back;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.right;
        }

    }
}
