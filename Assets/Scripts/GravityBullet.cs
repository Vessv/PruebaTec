using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBullet : Projectile
{
    public float AttractionForce = 20f;
    public float AttractionRadius = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    public override void Move()
    {
        base.Move();
    }

    private void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, AttractionRadius);

        foreach (Collider collider in colliders)
        {
            if (collider.gameObject != gameObject && collider.gameObject.CompareTag("Pullable"))
            {
                Rigidbody rb = collider.GetComponent<Rigidbody>();

                if (rb != null)
                {
                    Vector3 direccion = transform.position - collider.transform.position;
                    rb.AddForce(direccion.normalized * AttractionForce);
                }
            }
        }
    }
}
