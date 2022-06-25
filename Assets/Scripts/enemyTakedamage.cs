using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTakedamage : MonoBehaviour
{
    public float enemyHp = 10f;
    public float currentHp;

    private void Start()
    {
        currentHp = enemyHp;
    }
    public void enemyTakedamaged(float damage)
    {
        currentHp -= damage;
        if(currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
