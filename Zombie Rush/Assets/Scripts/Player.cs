using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float damage;
    public float rateOfFire;
    public float magSize;
    public float reloadSpeed;

    private GunSO equippedGun;
    private InventoryManager im;
    // Start is called before the first frame update
    void Start()
    {
        im = GameObject.FindAnyObjectByType<InventoryManager>();
        EquipItem1();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EquipItem1();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EquipItem2();
        }
    }

    public void EquipItem1()
    {
        equippedGun = im.inventory[0];
        damage = im.inventory[0].damage;
        rateOfFire = im.inventory[0].rateOfFire;
        magSize = im.inventory[0].magSize;
        reloadSpeed = im.inventory[0].reloadSpeed;
    }
    public void EquipItem2()
    {
        equippedGun = im.inventory[1];
        damage = im.inventory[1].damage;
        rateOfFire = im.inventory[1].rateOfFire;
        magSize = im.inventory[1].magSize;
        reloadSpeed = im.inventory[1].reloadSpeed;
    }
}
