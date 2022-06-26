using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyTakedamage : MonoBehaviour
{
    [SerializeField] GameObject exe;
    SpriteRenderer sprite;

    public float enemyHp = 10f;
    public float currentHp;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        currentHp = enemyHp;
    }
    public void enemyTakedamaged(float damage)
    {
        currentHp -= damage;
        StartCoroutine("EE");
        if(currentHp <= 0)
        {
            Destroy(gameObject);
            Instantiate(exe, transform.position, Quaternion.identity);
        }
    }
    IEnumerator EE()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
    }
}
