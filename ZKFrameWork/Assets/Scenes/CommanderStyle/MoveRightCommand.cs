using UnityEngine;
public class MoveRightCommand : Command
{
    public override void Execute(UnitCon unitCon)
    {
        MoveRight(unitCon);
    } 

    public void MoveRight(UnitCon unitCon)
    {
        unitCon.transform.Translate(Vector3.right * 2);
    }
}
