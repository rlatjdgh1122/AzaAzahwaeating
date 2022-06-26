using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exe : MonoBehaviour
{
    public float speed;
    Vector3 dir;
    private void Update()
    {
        GameObject pos = GameObject.Find("player");
        dir = pos.transform.position - transform.position;
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
