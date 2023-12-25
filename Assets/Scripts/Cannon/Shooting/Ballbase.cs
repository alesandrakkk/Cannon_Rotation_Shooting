using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballbase : MonoBehaviour
{
    public Rigidbody Rigidbody;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<Targetbase>(out var targetbase)){

            Debug.Log("Nice Shot");

            targetbase.GetDamage(Random.Range(2,50));

            gameObject.SetActive(false);
        }
    }
}
