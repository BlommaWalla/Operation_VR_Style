using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class bullet : MonoBehaviour
{
    //private Rigidbody m_rigidbody = null;

    //private Rigidbody Rigidbody { get => m_rigidbody; set => m_rigidbody = value; }

    void Start() {
        GetComponent<Rigidbody>().AddForce(transform.forward * 10, ForceMode.Impulse);
        Debug.Log("funky");

    }




}
