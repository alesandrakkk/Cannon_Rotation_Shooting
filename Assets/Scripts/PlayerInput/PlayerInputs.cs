using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
      
    public Vector2 InputRotation = new Vector2();

    public void Update(){

        InputRotation = (new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") * Time.deltaTime * rotationSpeed));
                         
    }
}
