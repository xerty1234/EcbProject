using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{

    public Image healthBar;
    public float currentHealth = 100;
    public float maxHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthBar();
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
            GameOver();
        }
        UpdateHealthBar();
    }

    public void Heal(float healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
        
    }

    private void GameOver()
    {
        // 게임 오버 처리
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
