using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifeTime = 5f;

    private Rigidbody m_RigidBody = null;

    private void Awake() {
        m_RigidBody = GetComponent<Rigidbody>() {
            SetInnactive();
        }

    }

    private void OnCollisionEnter(Collision collision) {
        SetInnactive();
    }

    public void Launch(Blaster blaster) {
        transform.position = blaster.transform.position;
        transform.rotation = blaster.transform.rotation;

        gameObject.SetActive(true);

        m_RigidBody.AddRelativeForce(Vector3.forward * 10, ForceMode.Impulse);
        StartCoroutine(TrackLifetime());
    }

    private IEnumerator TrackLifetime() {
        yield return new WaitForSeconds(m_Lifetime);
        SetInnactive();
    }

    public void SetInnactive() {
        m_RigidBody.velocity = Vector3.zero;
        m_RigidBody.angularVelocity = Vector3.zero;

        gameObject.SetActive(false);
    }
}
