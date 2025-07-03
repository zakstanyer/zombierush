using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public int enemiesAlive;
    public int currentWave;
    public GameObject[] spawners;
    public int enemiesToSpawn;
    public GameObject enemy;
    public TextMeshProUGUI waveText;

    // Start is called before the first frame update
    void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        currentWave = 0;
        RoundStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RoundStart()
    {
        currentWave++;
        waveText.text = "Wave " + currentWave.ToString();
        //spawn 3 enemies for round 1
        enemiesToSpawn = currentWave + 2;
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            AttemptSpawn();
        }
    }

    public void RoundEnd()
    {

    }

    private void AttemptSpawn()
    {
        foreach (GameObject spawner in spawners)
        {          
            if (spawner.GetComponent<Spawner>().isVisible == false)
            {
                SpawnEnemy(enemy,spawner.transform);
                return;
            }
        }
        AttemptSpawn();
    }

    private void SpawnEnemy(GameObject _enemy, Transform location)
    {
        Instantiate(_enemy, location);
        enemiesAlive++;
        _enemy.transform.localPosition = new Vector3(0, 0.5f, 0);
    }

}
