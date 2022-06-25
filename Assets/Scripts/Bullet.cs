using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;

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
    }
    void Update()
    {
        transform.Translate(Vector3.up * 1 * speed * Time.deltaTime);
    }
}
