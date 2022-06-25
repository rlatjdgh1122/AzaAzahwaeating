using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] PlayerFire player;
    public void BulletDamageUp()
    {
        player.CurrentbulletDamage += 1;
        player.closePanel();    
    }
}
