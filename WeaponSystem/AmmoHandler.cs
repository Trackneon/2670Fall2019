using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AmmoHandler : MonoBehaviour
{
    private Rigidbody rigidBodyObj;
    public Vector3 Forces;
    public WeaponConfig weaponObj;

    // Start is called before the first frame update
    void Start()
    {
        var renderer = GetComponent<Renderer>();
        renderer.material.color = weaponObj.weaponColor;
        rigidBodyObj = GetComponent<Rigidbody>();
        rigidBodyObj.AddForce(Forces);
        Destroy(gameObject, 1f);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        weaponObj.DoDamage();
    }

}
