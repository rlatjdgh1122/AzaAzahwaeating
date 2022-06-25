using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sundamage : MonoBehaviour
{
    public float speed = 5f;
    public float tick = 0.3f;
    public float damage = 1f;
    public float currentdamge;

    private void Start()
    {
        currentdamge = damage;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.GetComponent<enemyTakedamage>().enemyTakedamaged(currentdamge);
        }
    }
}
