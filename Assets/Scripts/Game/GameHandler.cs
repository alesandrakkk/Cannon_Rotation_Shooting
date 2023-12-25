using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public PlayerInputs InputModule;

    public RotateBase rotationModule;

    public Shootbase shootbaseModule;

    public UIHendler

    private void Update()
    {
        rotationModule.Rotate(InputModule.InputRotation);
                
    }

    private void KeyBoardInputs() {

        if (Input.GetKeyDown(KeyCode.F))
        {
            shootbaseModule.Shoot();
        }
    }

}
