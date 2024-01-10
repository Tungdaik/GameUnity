using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] protected  Vector3 targetPosition;
    
    protected static InputManager instance;
    public static InputManager Instance {  get { return instance; } }
    public Vector3 TargetPosition { get { return targetPosition; } }
    protected float onFiring;
    public float OnFiring { get {  return onFiring; } }
    protected float onMoving;
    public float OnMoving { get { return onMoving; } }
    private void Awake()
    {
        InputManager.instance = this; 
    }
    private void Update()
    {
        this.onFiring = Input.GetAxis("Fire1");
        this.onMoving = Input.GetAxis("Fire2");
    }
    void FixedUpdate()
    {
        this.SetPosition();
    }
    protected virtual void SetPosition()
    {
        this.targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
