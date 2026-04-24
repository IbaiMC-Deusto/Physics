using UnityEngine;

public class ShootRaycast: MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float force;
    private MeshRenderer mr;
    private Color originalColor;

    // Update is called once per frame
    void Update()
    {
        CheckShoot();
    }

    private void FixedUpdate()
    {
        ThrowRaycast();
    }

    void CheckShoot()
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

    void ThrowRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);

            MeshRenderer newMr = hit.collider.gameObject.GetComponent<MeshRenderer>();

            if (newMr == null) return;

            if (newMr == mr) return;
            
            if (mr != null) mr.material.color = originalColor;
           
            mr = newMr;
            originalColor = mr.material.color;
            mr.material.color = Color.green;
                
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            
            if (mr == null) return;

            mr.material.color = originalColor;
            mr = null;
        }
    }
}
