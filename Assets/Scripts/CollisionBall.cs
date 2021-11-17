using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBall : MonoBehaviour
{

    public float force = 10.0f;
    private Vector3 directionOfImpact;
    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));  //меняем цвет при ударе

            directionOfImpact = -1 * (collision.transform.position - transform.position);       //При попадании в цель импульс от неё
            rb.AddForce(directionOfImpact.normalized * force, ForceMode.Impulse);

        }

    }
}
