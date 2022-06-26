using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertakedamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerFire>().takedamage(10f);
            Destroy(gameObject);
        }
    }
}
