using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownFall : MonoBehaviour
{
    Vector3 startPos = new Vector3(0, 5, 0);

    private void OnCollisionEnter(Collision collision)
    {

        collision.rigidbody.velocity = startPos;
        collision.transform.position = startPos;
    }
}
