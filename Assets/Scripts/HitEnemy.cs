using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

       // GameObject col = collision.GetContact(0).thisCollider.gameObject;
        Destroy(this.gameObject);
    }
}
