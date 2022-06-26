using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class boss : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject bullet1;
    [SerializeField] GameObject bullet2;
    [SerializeField] GameObject bullet3;
    [SerializeField] Slider bossSlider;

    SpriteRenderer sprite;
    MoveMent move;

    public float enemyspon;
    public float time = 1f;
    float maxtime;
    float maxbullettime;
    public float bullettime = 1f;
    public float enemyHp = 10f;
    public float currentHp;

    private void Start()
    {
        maxtime = time;
        maxbullettime = bullettime;
        move = GetComponent<MoveMent>();
        sprite = GetComponent<SpriteRenderer>();

        currentHp = enemyHp;
        bossSlider.maxValue = enemyHp;
        bossSlider.value = enemyHp;
    }
    private void Update()
    {
        movepattern();
        time -= Time.deltaTime;
        bullettime -= Time.deltaTime;

        if (time < 0)
        {

            time = maxtime;
            float pattern = Random.Range(0, 2);
            float enemyyy = Random.Range(0, 10);
            float randomX = Random.Range(-10, 10);
            Vector3 x = new Vector3(randomX, 8.4f, 0);

            switch (pattern)
            {
                case 0:
                    Instantiate(bullet1, transform.position, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(bullet2, x, Quaternion.identity);

                    break;
                case 2:
                    Instantiate(bullet3, x, Quaternion.identity);
                    break;


            }

            if (enemyyy < enemyspon)
            {
                Instantiate(enemy, x, Quaternion.identity);
            }
        }
        //if(bullettime < 0)
        //{
        //bullettime = maxbullettime;
        //StartCoroutine("WW");

        //}


    }
    public void enemyTakedamaged(float damage)
    {
        currentHp -= damage;
        bossSlider.value -= damage;
        StartCoroutine("EE");
        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
    /* IEnumerator WW()
     {
         Instantiate(bullet1, transform.position, Quaternion.identity);
         yield return new WaitForSeconds(0.1f);
     }*/
    IEnumerator EE()
    {

        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;

    }
    public void movepattern()
    {
        if (transform.position.y <= 7.8f)
        {
            move.MoveTo(Vector3.zero);
        }
    }
}
