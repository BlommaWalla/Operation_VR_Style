using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class bullet : MonoBehaviour
{
    private Rigidbody m_rigidbody = null;


    

    void Move() {
        Debug.Log("funky");
        m_rigidbody.AddRelativeForce(Vector3.forward * 10, ForceMode.Impulse);
    }

    void start() { 
        Move();
    }


}
