using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] PlayerFire player;
    Sundamage sun;


    private void Start()
    {
        sun = GameObject.FindObjectOfType<Sundamage>();
    }
    public void BulletDamageUp()
    {
        player.CurrentbulletDamage += 0.1f;
        player.closePanel();    
    }
    public void SunBulletUp()
    {
        sun.currentdamge += 1f;
        player.closePanel();
    }

    public void PlayerSpeed()
    {
        player.speed += 3f;
        player.closePanel();
    }
}
