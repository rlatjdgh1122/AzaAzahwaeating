using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    MoveMent move;
    [SerializeField] GameObject bullet1;
    [SerializeField] GameObject bullet2;
    public float time = 2f;
    public float maxtime;
    float currnettime = 0;
    private void Start()
    {
        time = maxtime;
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
                time = maxtime;
                float random = Random.Range(0, 10);
                if (random < 0.1f)
                {
                    StartCoroutine("EE");
                }
            }
        }
    }
    IEnumerator EE()
    {
        while (true)
        {
            Instantiate(bullet1, transform.position + Vector3.right * 1f, Quaternion.identity);
            Instantiate(bullet2, transform.position + Vector3.left * 1f, Quaternion.identity);
            yield return new WaitForSeconds(1f);
            
        }
    }

}
