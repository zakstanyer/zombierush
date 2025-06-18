using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        Ray ray = new Ray(spawn.position, spawn.forward);
        RaycastHit hit;

        float shotDistance = 20;
        if (Physics.Raycast(ray, out hit, shotDistance))
        {
            shotDistance = hit.distance;
        }
        Debug.DrawRay(ray.origin, ray.direction * shotDistance, Color.red, 1);
    }

    public void ShootContinuous()
    {
        if(gunType == GunType.Auto)
        {
            Shoot();
        }
    }
}
