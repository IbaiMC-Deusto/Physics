using UnityEngine;

public class Movement_Rotation : MonoBehaviour
{
    [SerializeField] float velocityMovement;
    [SerializeField] float velocityRotation;
    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        Rotation();
    }

    void Movement()
    {

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 direction = this.transform.forward;
            direction = Quaternion.AngleAxis(-90, Vector3.up) * direction;
            this.transform.position += direction * velocityMovement * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 direction = this.transform.forward;
            direction = Quaternion.AngleAxis(90, Vector3.up) * direction;
            this.transform.position += direction * velocityMovement * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += this.transform.forward * velocityMovement * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        { 
            this.transform.position += -1 * this.transform.forward * velocityMovement * Time.deltaTime;
        }
    }
    void Rotation()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.rotation *= Quaternion.Euler(0, velocityRotation * Time.deltaTime, 0);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.rotation *= Quaternion.Euler(0, -1 * velocityRotation * Time.deltaTime, 0);
        }
    }
}
