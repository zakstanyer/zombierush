using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float damage;
    private float lifeTime = 1;
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindFirstObjectByType<Player>();
        damage = player.damage;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

        if(lifeTime < 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyHealthManager>().health -= damage;
            if(collision.gameObject.GetComponent<EnemyHealthManager>().health <= 0)
            {
                collision.gameObject.GetComponent<EnemyHealthManager>().Die();


            }
        }
    }
}
