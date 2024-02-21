using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCommand : Command
{
    private readonly float _scaleFactor;
    public ScaleCommand(IEntity entity, float scaleDirection) : base(entity)
    {
        _scaleFactor = scaleDirection == 1f? 1.1f : 0.9f;
    }

    public override void Execute()
    {
        _entity.Transform.localScale *= _scaleFactor;
    }

    public override void Undo()
    {
        _entity.Transform.localScale /= _scaleFactor;
    }
}
