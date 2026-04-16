using UnityEngine;

public class CheckCollision : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    { 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Capsule")
        {
            Debug.Log("Starting collision");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("Staying on collision");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("Exiting collision");
        }
        //Destroy(this.gameObject);
    }


}
