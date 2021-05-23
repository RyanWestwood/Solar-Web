using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem ps;
    public Transform bulletPos;
    public Transform bulletRot;
    public GameObject bullet;

    public GameplayUI ui;
    private int bulletCount = 12;
    private float reloadTime;

    public GameObject collectable;
    private int foodCount;


    enum Mouse{
        LEFT_CLICK = 0,
        RIGHT_CLICK,
        MIDDLE_CLICK
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        ui.BackpackCount(0);
        ui.BulletCount(12);
    }

    void Update()
    {
        if (bulletCount <= 0)
        {
            reloadTime += Time.deltaTime;
            if (reloadTime >= 1)
            {
                bulletCount = 12;
                ui.BulletCount(bulletCount);
                reloadTime = 0;
            }
        }
        else if (Input.GetMouseButtonDown((int)Mouse.LEFT_CLICK))
        {
            anim.SetBool("isShooting", true);
            anim.SetInteger("condition", 1);
            ps.Play();
            bulletCount--;
            ui.BulletCount(bulletCount);
            Instantiate(bullet, bulletPos.position, bulletPos.rotation);
        }
        else
        {
            anim.SetBool("isShooting", false);
        }

        if (foodCount == 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(collectable.gameObject);
                foodCount++;
                ui.BackpackCount(foodCount);
            }
        }
    }
}
