using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] PlayerFire player;
    Sundamage sun;
    [SerializeField] private Text scoreText;
    public int score;
    private void Update()
    {
        scoreText.text = "SCORE : " + score;
    }
    private void Start()
    {
        
        score = 0;
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
