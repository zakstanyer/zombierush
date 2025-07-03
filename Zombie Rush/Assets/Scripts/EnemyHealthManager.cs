using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour
{
    public float health;
    private Slider healthBar;
    private WaveManager waveManager;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponentInChildren<Slider>();
        health = 100;
        waveManager = FindFirstObjectByType<WaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;
    }

    public void Die()
    {
        waveManager.enemiesAlive--;
        if(waveManager.enemiesAlive <= 0)
        {
            waveManager.RoundEnd();
        }
        Destroy(gameObject);
    }
}
