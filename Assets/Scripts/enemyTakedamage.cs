using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyTakedamage : MonoBehaviour
{
    [SerializeField] GameObject exe;

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
            Instantiate(exe, transform.position, Quaternion.identity);
        }
    }
}
