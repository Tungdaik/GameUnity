using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class BulletStormSkill : BaseSkill
{
    protected static BulletStormSkill instance;
    protected int count = 0;
    protected int heso = 10;
    public static BulletStormSkill Instance => instance;
    [Header("Bullet Storm")]
    [SerializeField] protected bool running = false;
    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    protected override void Effect()
    {
       this.running = true;
    }

    protected override void Uneffect()
    {
        this.running = false;
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        if (!running) return;
        this.Spawnn();
      
    }

    protected void Spawnn()
    {
        count++;
        if (count % heso != 0) return;
        Quaternion rot = gameCrl.ShipCrl.transform.rotation;
        Quaternion rot2 = Quaternion.Euler(rot.eulerAngles + new Vector3(0, 0, 7.5f));
        Quaternion rot3 = Quaternion.Euler(rot.eulerAngles + new Vector3(0, 0, 15f));
        Quaternion rot4 = Quaternion.Euler(rot.eulerAngles + new Vector3(0, 0, -15f));
        Quaternion rot5 = Quaternion.Euler(rot.eulerAngles + new Vector3(0, 0, -7.5f));
        Transform newBullet = BulletSpawner.Instance.Spawn(KindOfBulletEnum.Ditmemay.ToString(), gameCrl.ShipCrl.transform.position, rot);
        Transform newBullet2 = BulletSpawner.Instance.Spawn(KindOfBulletEnum.Ditmemay.ToString(), gameCrl.ShipCrl.transform.position, rot2);
        Transform newBullet3 = BulletSpawner.Instance.Spawn(KindOfBulletEnum.Ditmemay.ToString(), gameCrl.ShipCrl.transform.position, rot3);
        Transform newBullet4 = BulletSpawner.Instance.Spawn(KindOfBulletEnum.Ditmemay.ToString(), gameCrl.ShipCrl.transform.position, rot4);
        Transform newBullet5 = BulletSpawner.Instance.Spawn(KindOfBulletEnum.Ditmemay.ToString(), gameCrl.ShipCrl.transform.position, rot5);
        BulletCrl bulletCrl = newBullet.GetComponent<BulletCrl>();
        bulletCrl.SetShooterName(transform.parent.parent.name);
        BulletCrl bulletCrl2 = newBullet2.GetComponent<BulletCrl>();
        bulletCrl2.SetShooterName(transform.parent.parent.name);
        BulletCrl bulletCrl3 = newBullet3.GetComponent<BulletCrl>();
        bulletCrl3.SetShooterName(transform.parent.parent.name);
        BulletCrl bulletCrl4 = newBullet4.GetComponent<BulletCrl>();
        bulletCrl4.SetShooterName(transform.parent.parent.name);
        BulletCrl bulletCrl5 = newBullet5.GetComponent<BulletCrl>();
        bulletCrl5.SetShooterName(transform.parent.parent.name);
        newBullet.gameObject.SetActive(true);
        newBullet2.gameObject.SetActive(true);
        newBullet3.gameObject.SetActive(true);
        newBullet4.gameObject.SetActive(true);
        newBullet5.gameObject.SetActive(true);

    }
}
