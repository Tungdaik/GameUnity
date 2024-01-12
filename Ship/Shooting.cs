using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shooting : TungMonoBehaviour
{
   
   
    [SerializeField] protected float timePerShoot = 2f;
    [SerializeField] protected float indexTime = 0f;
    [SerializeField] protected KindOfBulletEnum kindOfBullet = KindOfBulletEnum.Ditmemay;
     protected virtual void  FixedUpdate()
    {
        if(!IsShooting()) return;
        this.Shoot();
    }
    protected virtual void Shoot()
    {
        indexTime += 0.2f;
        
        
        if (indexTime < timePerShoot) return;
        indexTime = 0f;
        Vector3 spawnPos = transform.parent.position;
        Quaternion spawnRot = transform.parent.rotation;

        Transform newTransform = BulletSpawner.Instance.Spawn(kindOfBullet.ToString(),spawnPos, spawnRot);
        BulletCrl bulletCrl = newTransform.GetComponent<BulletCrl>();
        bulletCrl.SetShooterName(transform.parent.name);
        if (newTransform == null ) {
            //
                                     }
          newTransform.gameObject.SetActive(true);
    }
    protected abstract bool IsShooting();

    
}
