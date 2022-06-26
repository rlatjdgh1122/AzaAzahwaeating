using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class boss : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Slider bossSlider;

    SpriteRenderer sprite;
    MoveMent move;

    public float enemyspon;
    public float time = 1f;
    public float enemyHp = 10f;
    public float currentHp;

    private void Start()
    {
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
        if (time < 0)
        {

            time = 1;
            float enemyyy = Random.Range(0, 10);
            float randomX = Random.Range(-10, 10);
            Vector3 x = new Vector3(randomX, 8.4f, 0);

            if (enemyyy < enemyspon)
            {
                Instantiate(enemy, x, Quaternion.identity);
            }

        }

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
