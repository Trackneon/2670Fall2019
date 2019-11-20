using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AmmoHandler : MonoBehaviour
{
    private Rigidbody rigidBodyObj;
    public Vector3 Forces;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyObj = GetComponent<Rigidbody>();
        rigidBodyObj.AddForce(Forces);
        Destroy(gameObject, 1f);

    }

}
