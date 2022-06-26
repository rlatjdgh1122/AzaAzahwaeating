using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lader : MonoBehaviour
{
    float playtime = 0;
    public float time;
    float scaleX = 0;
    float scaleY = 0;
    bool iscooltime = false;

    private void Update()
    {
        cooltime();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("EnemyBullet")
            || collision.gameObject.CompareTag("BossBullet"))
        {
            Destroy(collision.gameObject);
            transform.localScale = new Vector3(0, 0, 0);
            iscooltime = true;
        }
    }
    void cooltime()
    {
        if (iscooltime == true)
        {
            playtime += Time.deltaTime;
            if (playtime >= time)
            {
                scaleX += 0.01f;
                scaleY += 0.01f;

                if (scaleX <= 5)
                    transform.localScale = new Vector3(scaleX, scaleY, 0);

                else if (scaleX > 5)
                {
                    iscooltime = false;
                    scaleX = 0;
                    scaleY = 0;
                    playtime = 0;
                }
            }

        }
    }
}
