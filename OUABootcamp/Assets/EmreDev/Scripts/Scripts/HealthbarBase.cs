using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBase : MonoBehaviour
{
    public PlayerData playerData; // PlayerData referans�

    private int currentHealth;
    [SerializeField] private Image Kare;

    public virtual void Awake()
    {
        if (playerData == null)
        {
            Debug.LogError("PlayerData is not assigned in HealthBase.");
            return;
        }

        if (Kare == null)
        {
            Debug.LogError("Image Kare is not assigned in HealthBase.");
            return;
        }

        currentHealth = playerData.PlayerHealth; // PlayerData'dan sa�l�k de�eri �ekiliyor
        ChangeHealthBar(); // Health bar g�ncelleniyor
        Debug.Log("Awake: currentHealth = " + currentHealth + ", playerMaxHealth = " + playerData.PlayerMaxHealth);
    }

    public void ChangeCurrentHealth(int value)
    {
        currentHealth += value;

        if (currentHealth > playerData.PlayerMaxHealth)
        {
            currentHealth = playerData.PlayerMaxHealth;
        }
        else if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        // PlayerData'n�n sa�l�k de�erini g�ncelle
        playerData.PlayerHealth = currentHealth;

        ChangeHealthBar();

        Debug.Log("ChangeCurrentHealth: currentHealth = " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void IncreaseHealth(int value)
    {
        ChangeCurrentHealth(value);
    }

    public void DecreaseHealth(int value)
    {
        ChangeCurrentHealth(-value);
    }

    private void ChangeHealthBar()
    {
        if (Kare != null)
        {
            Kare.fillAmount = (float)currentHealth / playerData.PlayerMaxHealth;
            Debug.Log("ChangeHealthBar: Kare.fillAmount = " + Kare.fillAmount);
        }
        else
        {
            Debug.LogError("Kare is not assigned.");
        }
    }

    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
}