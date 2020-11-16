using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VRTK_InteractableObject>().InteractableObjectUsed += Shoot;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot(object sender, InteractableObjectEventArgs e) {

    }
}
