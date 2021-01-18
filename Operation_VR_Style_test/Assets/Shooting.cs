using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Shooting : MonoBehaviour {
    public GameObject bullet;
    public Transform barrel;

    private GameObject m_projectile;
    void Start() {
        GetComponent<VRTK_InteractableObject>().InteractableObjectUsed += Shoot;
    }

    void Shoot(object sender, InteractableObjectEventArgs e) {
        m_projectile = Instantiate(bullet, barrel.position, barrel.rotation);

    }
}
