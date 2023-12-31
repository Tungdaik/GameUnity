using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCrl : TungMonoBehaviour
{
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
    }
}
