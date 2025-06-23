using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class Gun : MonoBehaviour
{
    public Transform spawn;

    public enum GunType
    {
        Semi,
        Burst,
        Auto
    };

    public GunType gunType;
    [Header("Number of times the gun can shoot per second.")]
    public float rateOfFire;
    public GameObject bullet;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime / rateOfFire;
        }
    }


    public void Shoot()
    {
        if(timer <= 0)
        {
            timer = 1;
            GameObject _bullet = Instantiate(bullet, spawn.transform.position, Quaternion.identity);
            _bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 20, ForceMode.Impulse);

            Ray ray = new Ray(spawn.position, spawn.forward);
            RaycastHit hit;

            float shotDistance = 20;
            if (Physics.Raycast(ray, out hit, shotDistance))
            {
                shotDistance = hit.distance;
            }
        }

    }

    public void ShootContinuous()
    {
        if(gunType == GunType.Auto)
        {
            Shoot();
        }
    }
}
