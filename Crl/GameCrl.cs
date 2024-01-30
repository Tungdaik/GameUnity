using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCrl : TungMonoBehaviour

{
    [SerializeField] protected int limitEnemyOne;
    public int LimitedEnemyOne { get {  return limitEnemyOne; } }
    [SerializeField] protected int limitUFO;
    public int LimitedUFO { get { return limitUFO; } }
    [SerializeField] protected int limitJunk;
    public int LimitJunk { get { return limitJunk; } }
    [SerializeField] protected float timePerObj;
    public float TimePerObj { get { return timePerObj; } }
    [SerializeField] protected MapSO currentMap;

    [SerializeField] protected int  scoreGame;
    public int ScoreGame { get { return scoreGame; } set { scoreGame = value; } }
    [SerializeField] protected float enemyOneCount;
    public float EnemyOneCount { get { return enemyOneCount; } set { enemyOneCount = value; } }
    [SerializeField] protected float ufoCount;
    public float UFOCount { get { return ufoCount; } set { ufoCount = value; } }

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
        this.InitMap();
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
    public virtual void AddScore(int value)
    {
        this.scoreGame += value;
        this.CheckUpdate();
    }
    protected virtual void CheckUpdate()
    {
        if (scoreGame > currentMap.mapDetails[currentMap.currentLevel + 1].scoreToUnlock) this.UpdateMap();
    }
    protected virtual void UpdateMap()
    {
        currentMap.currentLevel++;
        this.limitUFO = currentMap.mapDetails[currentMap.currentLevel].limitUFO;
        this.limitEnemyOne = currentMap.mapDetails[currentMap.currentLevel].limitEnemyOne;
        this.timePerObj = currentMap.mapDetails[currentMap.currentLevel].timePerObj;
    }
    protected virtual void InitMap()
    {
        this.limitUFO = currentMap.mapDetails[0].limitUFO;
        this.limitEnemyOne = currentMap.mapDetails[0].limitEnemyOne;
        this.timePerObj = currentMap.mapDetails[0].timePerObj;
        this.limitJunk = 70;
        currentMap.currentLevel = 0;
    }
}
