using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Starting collision");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Staying on collision");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Exiting collision");
        }
        //Destroy(this.gameObject);
    }
}
