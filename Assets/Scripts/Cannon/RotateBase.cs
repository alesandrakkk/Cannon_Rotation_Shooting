using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBase : AbstRotateAxis
{
    [SerializeField] private Transform axis;

    [SerializeField] private Vector2 current;

    void Awake()
    {
        ApplyRotation();
    }

    void ApplyRotation()
    {
        Vector3 direction = transform.forward;

        axis.rotation = Quaternion.Euler(current.y, current.x, 0);
    }

    public override void Rotate(Vector2 vector)
    {
        current += vector;
        ApplyRotation();
    }
}