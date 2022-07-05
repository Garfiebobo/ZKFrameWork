
public class Command 
{
    /// <summary>
    /// /执行操作
    /// </summary>
    /// <param name="_unitcon"></param>
    public virtual void Execute(UnitCon _unitcon) { }

    /// <summary>
    /// 撤销操作
    /// </summary>
    public virtual void Undo() { }
}
