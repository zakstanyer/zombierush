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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EquipItem1();
        }
    }

    public void EquipItem1()
    {
        equippedGun = im.inventory[0];
    }
}
