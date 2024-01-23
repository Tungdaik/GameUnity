using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCrl : TungMonoBehaviour

{
    [SerializeField] protected float enemyOneCount;
    public float EnemyOneCount { get { return enemyOneCount; } set { enemyOneCount = value; } }
    [SerializeField] protected float junkCount;
    public float JunkCount { get { return junkCount; } set { junkCount = value; } }
    [SerializeField] protected ShipCrlBeta shipCrl;
    public ShipCrlBeta ShipCrl => shipCrl;
    [SerializeField] protected static GameCrl instance;
    [SerializeField] protected Transform mainCam;
    public Transform MainCam { get { return mainCam; } }
    public static GameCrl Instance { get { return instance; } }
    protected override void Awake()
    {
        base.Awake();
        GameCrl.instance = this;
    }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.mainCam = Transform.FindObjectOfType<Camera>().transform;
        this.LoadShipCrl();
    }
    protected virtual void LoadShipCrl()
    {
        this.shipCrl = Transform.FindObjectOfType<ShipCrlBeta>();
    }
}
