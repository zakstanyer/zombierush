using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    private int currentWave;
    private int enemiesAlive;
    public GameObject[] spawners;
    public int enemiesToSpawn;
    public GameObject enemy;

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
        //spawn 3 enemies for round 1
        enemiesToSpawn = currentWave + 2;
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            print("YUP");
            AttemptSpawn();
        }
    }
    private void AttemptSpawn()
    {
        foreach (GameObject spawner in spawners)
        {          
            if (spawner.GetComponent<Spawner>().isVisible == false)
            {
                Debug.Log("YUP2");
                SpawnEnemy(enemy,spawner.transform);
                return;
            }
        }
        AttemptSpawn();
    }

    private void SpawnEnemy(GameObject _enemy, Transform location)
    {
        Instantiate(_enemy, location);
        _enemy.transform.localPosition = new Vector3(0, 0.5f, 0);
    }
}
