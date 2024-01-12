using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrl : TungMonoBehaviour
{
    [SerializeField] protected static PlayerCrl instance;
    public static PlayerCrl Instance { get { return instance; } }
    [SerializeField] protected PlayerPickUp playerPickUp;
    public PlayerPickUp PlayerPickUp { get {  return playerPickUp; } }
    [SerializeField] protected ShipCrlBeta currentShip;
    public ShipCrlBeta CurrentShip { get { return currentShip; } }
    protected override void Awake()
    {
        base.Awake();
        PlayerCrl.instance = this;
    }
    protected override void LoadCompoments()
    {
        base.LoadCompoments();
        this.LoadCurrentShip();
        this.LoadPlayerPickUp();
    }
    protected virtual void LoadCurrentShip()
    {
        this.currentShip = Transform.FindObjectOfType<ShipCrlBeta>();
    }
    protected virtual void LoadPlayerPickUp() {

        this.playerPickUp = transform.GetComponentInChildren<PlayerPickUp>();
            
    }
}
