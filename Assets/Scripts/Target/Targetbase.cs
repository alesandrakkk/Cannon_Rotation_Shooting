using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetbase : MonoBehaviour
{
    public TargetLevel level;

    public enum TargetLevel
    {
        Easy,
        Medium,
        Hard
    }

    private int hp = 100;

   

    public void SwitchLevel()
    {
        switch (level)
        {
            case TargetLevel.Easy:
                Debug.Log("You get 10 point xp");
                break;
            case TargetLevel.Medium:
                Debug.Log("You get 15 point xp");
                break;
            case TargetLevel.Hard:
                Debug.Log("You get 20 point xp");
                break;
        }
    }

    public void GetDamage(int damage){

        Debug.Log($"Brought damage { damage}");

        hp -= damage;

        if (hp <= 0)

        TargetCrush();
    }

    private void TargetCrush(){

        gameObject.SetActive(false);

    }
}
