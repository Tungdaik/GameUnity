using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected bool shooting = false;
   
    [SerializeField] protected float timePerShoot = 2f;
    [SerializeField] protected float indexTime = 0f;
    [SerializeField] protected string kindOfBullet = "Ditmemay";
     void FixedUpdate()
    {
        this.IsShooting();
        this.Shooting();
    }
    protected virtual void Shooting()
    {
        indexTime += 0.2f;
        if (!shooting) return;
        
        if (indexTime < timePerShoot) return;
        indexTime = 0f;
        Vector3 spawnPos = transform.parent.position;
        Quaternion spawnRot = transform.parent.rotation;

        Transform newTransform = BulletSpawner.Instance.Spawn(kindOfBullet,spawnPos, spawnRot);
        if (newTransform == null ) {
            //
                                     }
          newTransform.gameObject.SetActive(true);
    }
    protected virtual void IsShooting()
    {
        this.shooting = InputManager.Instance.OnFiring == 1;
    }

    
}
