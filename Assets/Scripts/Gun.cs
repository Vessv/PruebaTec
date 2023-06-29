using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "Gun")]
public class Gun : ScriptableObject
{
    public float fireRate;
    public GameObject bulletObject;
    public Mesh weaponMesh;
    public void Shoot(Transform firePoint)
    {
        GameObject bullet = Instantiate(bulletObject, firePoint.position, firePoint.rotation);
        Destroy(bullet, 10f);
    }
}


