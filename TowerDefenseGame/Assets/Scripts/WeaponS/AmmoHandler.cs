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
    public GameObject enemyPrefab;
    
    void Start()
    {
        var renderer = GetComponent<Renderer>();
        renderer.material.color = weaponObj.weaponColor;
        rigidbodyObj = GetComponent<Rigidbody>();
        rigidbodyObj.AddForce(Forces);
        Destroy(gameObject, 3f);
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}