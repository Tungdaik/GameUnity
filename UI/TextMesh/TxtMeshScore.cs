using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtMeshScore : BaseTextMesh
{
    protected override void SetText()
    {
        int value = GameCrl.Instance.ScoreGame;
        this.textMesh.SetText(value.ToString());
    }
}
