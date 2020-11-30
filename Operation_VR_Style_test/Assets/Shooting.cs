using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class Shooting : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        GetComponent<VRTK_InteractableObject>().InteractableObjectUsed += Shoot;
    }

    void Shoot(object sender, InteractableObjectEventArgs e) {
        Debug.Log("pang");
        //Instantiate(bullet, new Vector3(0, 0, 0), Quaternion.identity);


    }


}
