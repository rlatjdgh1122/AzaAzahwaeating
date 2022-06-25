using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exe : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("È÷È÷");
            Destroy(gameObject);
        }
    }
}
