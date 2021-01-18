using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class bullet : MonoBehaviour
{
    public int force = 10;

    void Start() {
        GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);

    }




}
