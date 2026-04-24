using UnityEngine;

public class WallLife : MonoBehaviour
{
   public int lifes = 3;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Bullet")) return;
        Destroy(other.gameObject);
        lifes--;

        if (lifes <= 0) Destroy(this.gameObject);
    }
}
