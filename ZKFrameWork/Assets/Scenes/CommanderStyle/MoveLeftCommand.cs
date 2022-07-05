using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : Command
{
    public override void Execute(UnitCon unitcon)
    {
        MoveLeft(unitcon);
    }

    public override void Undo()
    {
        
    }

    public void MoveLeft(UnitCon unitCon)
    {
        unitCon.transform.Translate(Vector3.left * 2);
    }
}
