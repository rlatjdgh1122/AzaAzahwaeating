using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("bullet") || collision.gameObject.CompareTag("BossBullet") ||
            collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
