using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OurBullet : MonoBehaviour
{
    public float speed;
    public float lifeTime = 2.0f; 

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
        Destroy(gameObject, lifeTime); 

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject); 
    }
}
}