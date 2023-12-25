using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    [SerializeField] private RotateBase rotatebase;

    [SerializeField] private Shootbase shootBase;

    public void Update(){

        rotatebase.Rotate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") * Time.deltaTime * rotationSpeed));
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            shootBase.Shoot();
        }
            
    }
}
