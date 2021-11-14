using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    float maxHealth = 100f;
    float currentHealth;

    public Slider Healthbar;

    public GameObject damageScreen;

    public AudioSource audioSource;
    public AudioClip damageSFX;

    void Start()
    {
        currentHealth = maxHealth;

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        CalculateHealth();
        Healthbar.value = CalculateHealth();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        audioSource.pitch = 0.5f;
        audioSource.PlayOneShot(damageSFX);
        audioSource.pitch = 1f;
        damageScreen.GetComponent<FadeOut>().Inked();
    }

    float CalculateHealth()
    {
        return currentHealth / maxHealth;
    }

    void Die()
    {
        Debug.Log("You died you fool");
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("GameOver");
    }
}
