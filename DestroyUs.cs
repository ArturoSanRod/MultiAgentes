using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUs : MonoBehaviour
{
    public int attackDamage = 1;
    GameObject PlayerObject;
    PlayerHealthTest playerHealth;

    void Awake()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Player");
        playerHealth = PlayerObject.GetComponent<PlayerHealthTest>();
    }

    void OnTriggerEnter(Collider other) // Corrige a "OnTriggerEnter"
    {
        if (other.gameObject == PlayerObject)
        {
            playerHealth.TakeDamage(attackDamage);
            Destroy(gameObject);
        }
    }
}
