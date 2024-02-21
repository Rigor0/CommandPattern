using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Concrete Command
/// </summary>
public class MoveOnXAxisCommand : ICommand
{
    private Cube _cube;

    public MoveOnXAxisCommand(Cube cube)
    {
        _cube = cube;
    }

    public void Execute()
    {
        _cube.MoveOnXAxis();
    }

    public void Undo()
    {
        _cube.MoveBack();
    }
}
