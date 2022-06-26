using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    PlayerFire player;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerFire>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.GetComponent<enemyTakedamage>().enemyTakedamaged(player.CurrentbulletDamage);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            collision.GetComponent<boss>().enemyTakedamaged(player.CurrentbulletDamage);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
