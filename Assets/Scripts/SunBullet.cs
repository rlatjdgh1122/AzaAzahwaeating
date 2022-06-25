using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SunBullet : MonoBehaviour
{

    public Slider Sunslider;


    public GameObject test;
    public Vector3 dir;
    public Transform pos;

    public float MaxTime = 3f;
    [SerializeField] float currentTime;
    public float speed = 3f;
    public float gametime = 10;

    float h = 0;
    float v = 0;
    bool ismove = false;
    bool isplay = false;
    bool isscale = false;
    bool cooltime = false;


    void Start()
    {
        currentTime = MaxTime;
        Sunslider.maxValue = gametime;
        Sunslider.value = gametime;

    }

    void Update()
    {
       // float time = (gametime - Time.time);

        if (currentTime <= 0)
        {
            Sunslider.value = 10;
           // time = gametime;
            cooltime = false;

        }
        if (cooltime == true)
        {
            if(currentTime >= 0)
            {
                Sunslider.value = currentTime;
            }
        }




        if (isplay == false)
        {

            if (Input.GetKey(KeyCode.X))
            {
                test.transform.position = pos.transform.position;

                h += 0.01f * Time.deltaTime;
                v += 0.01f * Time.deltaTime;
                if (isscale == false)
                {
                    test.transform.localScale += new Vector3(h, v, 0);
                }
            }

            else if (Input.GetKeyUp(KeyCode.X))
            {
                test.transform.localScale += new Vector3(h, v, 0);
                ismove = true;
                cooltime = true;

                currentTime = MaxTime;
                h = 0;
                v = 0;
            }
        }

        if (test.transform.position.y >= 12)
        {
            test.transform.localScale = new Vector3(0, 0, 0);
        }

        if (ismove == true)
        {
            isplay = true;
            test.transform.position += dir * speed * Time.deltaTime;


            currentTime -= Time.deltaTime;
        }

        if (currentTime <= 0)
        {
            isplay = false;
            isscale = false;

        }



        if (test.transform.localScale.x >= 1f)
        {
            isscale = true;
        }
    }
}
