using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttoncolor : MonoBehaviour
{
    Text sprite;

    void Start()
    {
        sprite = GetComponent<Text>();
        StartCoroutine("EE");
    }

    IEnumerator EE()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.5f);
            sprite.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            sprite.color = Color.white;

        }
    }
}
