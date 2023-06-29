using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGun : MonoBehaviour
{
    public Gun weaponSO;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<GunHandler>().AddNewGun(weaponSO);
            Destroy(transform.root.gameObject);
        }
    }
}
