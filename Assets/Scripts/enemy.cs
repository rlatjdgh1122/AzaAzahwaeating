using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    MoveMent move;
    [SerializeField] GameObject bullet1;
    [SerializeField] GameObject bullet2;
    public float time = 3f;
    public float maxtime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerFire>().takedamage(10f);
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        maxtime = time;
        move = GetComponent<MoveMent>();
    }
    private void Update()
    {
        if (transform.position.y <= 6)
        {
            move.MoveTo(Vector3.zero);
            time -= Time.deltaTime;
            if (time < 0)
            {
                Instantiate(bullet1, transform.position + Vector3.right * 1f + Vector3.down * 1f, Quaternion.identity);
                Instantiate(bullet2, transform.position + Vector3.left * 1f + Vector3.down * 1f, Quaternion.identity);
                time = maxtime;
            }


        }

    }
}
