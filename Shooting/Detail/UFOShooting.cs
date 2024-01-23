using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOShooting : Shooting
{
    [SerializeField] protected Transform targetObj;
    [SerializeField] protected float limitDistance = 5f;
    protected override bool IsShooting()
    {
        return Vector3.Distance(targetObj.position, transform.parent.position) <= this.limitDistance;
    }
    protected override void Shoot()
    {
        isReady = false;
        indexTime = 0f;

        Vector3 spawnPos = transform.parent.position;
        Quaternion spawnRot = this.GetRot();

        Transform newTransform = BulletSpawner.Instance.Spawn(kindOfBullet.ToString(), spawnPos, spawnRot);
        BulletCrl bulletCrl = newTransform.GetComponent<BulletCrl>();
        bulletCrl.SetShooterName(transform.parent.name);
        if (newTransform == null)
        {
            //
        }
        newTransform.gameObject.SetActive(true);
    }
    protected virtual Quaternion GetRot()
    {
        Vector3 diff = this.targetObj.position - transform.parent.position;
       // currentDistance = diff.magnitude;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;
        Quaternion Rot = Quaternion.Euler(0f, 0f, -rot_z);
        return Rot;
    }
}
