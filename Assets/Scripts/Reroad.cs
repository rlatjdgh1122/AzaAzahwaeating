using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reroad : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    float scrSize = 9.9f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -scrSize)
        {
            transform.position = target.transform.position + Vector3.up * scrSize;
        }
    }

}
