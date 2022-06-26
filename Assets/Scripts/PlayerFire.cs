using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] StageData stage;
    [SerializeField] Slider Hpslider;
    [SerializeField] Slider LevelUpslider;
    [SerializeField] GameObject LevelUpPanel = null;

    SpriteRenderer sprite;

    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;

    public float bulletDamage = 1f;
    public float CurrentbulletDamage = 1f;
    public float currentTime;
    public float speed = 3f;
    public float attackSpeed = 1f;
    public float playerHp = 10f;
    public float MaxExe = 10f;
    private float currentHp;

    public void Start()
    {
        CurrentbulletDamage = bulletDamage;
        sprite = GetComponent<SpriteRenderer>();
        LevelUpPanel.SetActive(false);
        currentHp = playerHp;
        Hpslider.maxValue = currentHp;
        Hpslider.value = currentHp;
        LevelUpslider.maxValue = MaxExe;
        LevelUpslider.value = 0;
    }
    void Update()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(h, v, 0);
        transform.Translate(dir * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCo();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCo();
        }



    }
    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stage.LimitMin.x, stage.LimitMax.x),
            Mathf.Clamp(transform.position.y, stage.LimitMin.y, stage.LimitMax.y), 0);

        if (LevelUpslider.value == MaxExe)
        {
            LevelUpslider.value = 0;
            LevelUpPanel.SetActive(true);

        }
    }
    public void StartCo()
    {
        StartCoroutine("EE");
    }
    public void StopCo()
    {
        StopCoroutine("EE");
    }
    IEnumerator EE()
    {
        while (true)
        {
            GameObject Bullet1 = Instantiate(bullet1, transform.position + Vector3.right * 0.5f, transform.rotation);
            GameObject Bullet2 = Instantiate(bullet2, transform.position + Vector3.left * 0.7f , transform.rotation);
            GameObject Bullet3 = Instantiate(bullet3, transform.position + Vector3.right * 1.5f + Vector3.down * 1f, transform.rotation);
            GameObject Bullet4 = Instantiate(bullet4, transform.position + Vector3.left * 1.7f + Vector3.down * 1f, transform.rotation);

            yield return new WaitForSeconds(attackSpeed);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("exe"))
        {
            Destroy(collision.gameObject);
            LevelUpslider.value += 1;
        }
    }
    public void takedamage(float damage)
    {
        currentHp -= damage;
        Hpslider.value = currentHp;
        StartCoroutine("WW");
    }
    IEnumerator WW()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
    }
    public void closePanel()
    {
        LevelUpPanel.SetActive(false);
    }
}
