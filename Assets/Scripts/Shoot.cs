using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float force;

    void Update()
    {
        checkShoot();
    }

    void checkShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = this.transform.localPosition;

            Vector3 direction = this.transform.forward;
            Vector3 bulletForce = direction * force;

            newBullet.GetComponent<Rigidbody>().AddForce(bulletForce);
        }
    }
}
