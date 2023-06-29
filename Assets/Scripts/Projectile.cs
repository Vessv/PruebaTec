using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{

    public float speed;
    public bool canBounce = false;
    public GameObject hitEffect;
    public Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Move();
    }

    public virtual void Move()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (canBounce)
        {
            Vector3 normal = collision.contacts[0].normal;
            Vector3 bounce = Vector3.Reflect(rb.velocity.normalized, normal);
            rb.velocity = bounce * rb.velocity.magnitude;
        }
        else
        {
            GameObject effect = Instantiate(hitEffect, transform.position, transform.rotation);
            Destroy(effect, 1f);
            Destroy(gameObject);
        }

    }
}
