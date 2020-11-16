using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
public class Blaster : MonoBehaviour {

    //public SteamVR_Action_Boolean m_FireAction = null;

    public GameObject m_ProjectilePrefab = null;

    private ProjectilePool m_ProjectilePool = null;

    private void Awake() {
        m_ProjectilePool = new ProjectilePool(m_ProjectilePrefab, 5);
    }
}
