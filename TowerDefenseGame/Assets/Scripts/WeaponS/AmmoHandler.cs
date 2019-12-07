using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AmmoHandler : MonoBehaviour
{
    private Rigidbody rigidbodyObj;
    public Vector3 Forces;
    public WeaponConfig weaponObj;
    
    void Start()
    {
        var renderer = GetComponent<Renderer>();
        renderer.material.color = weaponObj.weaponColor;
        rigidbodyObj = GetComponent<Rigidbody>();
        rigidbodyObj.AddForce(Forces);
        Destroy(gameObject, 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        weaponObj.DoDamage();
    }
}