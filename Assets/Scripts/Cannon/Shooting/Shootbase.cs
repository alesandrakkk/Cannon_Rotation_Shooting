using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootbase : MonoBehaviour
{

    [SerializeField] private Ballbase ballPrefab;

    [SerializeField] private Transform indicatorTransform;

    public float force;

    Vector3 direction = new Vector3();
 
    private List<Ballbase> ballPool = new List<Ballbase>();

    public void Shoot() {

        direction = indicatorTransform.forward + transform.forward;

        Ballbase currentBall = LookFreeBall();

        if (currentBall == null)
        {
            currentBall = NewObjectCreation(); 

        }
                    

        currentBall.Rigidbody.AddForce(direction * force, ForceMode.VelocityChange);
    }

    private Ballbase NewObjectCreation() {

        var go = Instantiate(ballPrefab, transform.position, Quaternion.identity, null);
                
        ballPool.Add(go);

        return go;

    }

    private Ballbase LookFreeBall() {

        foreach (var item in ballPool)
        {
            if(!item.isActiveAndEnabled)
            {
                item.transform.position = transform.position;
                item.Rigidbody.velocity = Vector3.zero;

                return item;
            }

        }
        return null;
    }
}


