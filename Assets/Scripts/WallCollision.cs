using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        { 
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
