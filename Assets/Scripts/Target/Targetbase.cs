using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetbase : MonoBehaviour
{
    private int hp = 100;

    public void GetDamage(int damage){

        Debug.Log($"Brought damage { damage}");

        hp -= damage;

        if (hp <= 0)

        TargetDestroy();
    }

    private void TargetDestroy(){

        gameObject.SetActive(false);

    }
}
