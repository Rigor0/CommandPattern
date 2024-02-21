using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnYAxisCommand : ICommand
{
    private Cube _cube;

    public MoveOnYAxisCommand(Cube cube)
    {
        _cube = cube;
    }

    public void Execute()
    {
        _cube.MoveOnYAxis();
    }

    public void Undo()
    {
        _cube.MoveBack();
    }
}
