using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicProjectile : Projectile
{
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
        Move();
    }

    public override void Move()
    {
        base.Move();
    }
}
