using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public PlayerInputs InputModule;

    public RotateBase rotationModule;

    public Shootbase shootbaseModule;

    

    void Update()
    {
        rotationModule.Rotate(InputModule.InputRotation);

        KeyBoardInput();
    }

    private void KeyBoardInput()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            shootbaseModule.Shoot();
        }
    }


}
