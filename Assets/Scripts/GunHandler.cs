using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunHandler : MonoBehaviour
{
    List<Gun> _guns = new List<Gun>();
    public Transform FirePoint;

    [SerializeField]
    int _gunIndex = 0;

    [SerializeField]
    float _fireRateTime = 0f;

    public MeshFilter MeshFilter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_fireRateTime > 0f)
        {
            _fireRateTime -= Time.deltaTime;
        }
    }

    public void AddNewGun(Gun gun)
    {
        _guns.Add(gun);
        UpdateGun(_gunIndex);
    }

    public void OnClick(InputValue value)
    {
        if(_guns.Count <= 0)
        {
            return;
        }
        if (_fireRateTime > 0f)
        {
            return;
        }
        _fireRateTime = _guns[_gunIndex].fireRate;
        _guns[_gunIndex].Shoot(FirePoint);
    }

    public void UpdateGun(int index)
    {
        MeshFilter.mesh = _guns[_gunIndex].weaponMesh;
    }

    bool performed = false;
    public void OnGunChange(InputValue value)
    {
        performed = !performed;
        if (performed)
        {
            return;
        }
        if (_guns.Count <= 0)
        {
            return;
        }
        _gunIndex++;
        if (_gunIndex >= _guns.Count) _gunIndex = 0;
        UpdateGun(_gunIndex);
    }
}
