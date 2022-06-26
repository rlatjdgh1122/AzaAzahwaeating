using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybulletmove : MonoBehaviour
{
    public float speed =3f;
    Vector3 dir;
    public void Start()
    {
        float  randomX = Random.Range(-2,2);
        Vector3 r = new Vector3(randomX, -1, 0);
        dir = r;
    }

    // Update is called once per frame
    public void Update()
    {
        transform.position += dir * speed * Time.deltaTime;   
    }
}
