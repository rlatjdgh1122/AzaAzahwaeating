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

    public GameObject Bullet;
    public GameObject bullet;
    public Transform pos;

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
            GameObject bullet1 = Instantiate(Bullet, transform.position + Vector3.right * 0.5f, transform.rotation);
            GameObject bullet2 = Instantiate(bullet, transform.position + Vector3.left * 0.7f, transform.rotation);

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
        playerHp -= damage;
        Hpslider.value = currentHp;
    }
    public void closePanel()
    {
        LevelUpPanel.SetActive(false);
    }
}
