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
        player.CurrentbulletDamage += 0.5f;
        player.closePanel();    
    }
    public void SunBulletDamage()
    {
        sun.currentdamge += 0.5f;
        player.closePanel();
    }
}
