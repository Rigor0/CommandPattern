using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Client
/// </summary>
public class UserInput : MonoBehaviour
{
    [SerializeField] private Cube _cube;

    private MovementInvoker _movementInvoker;

    private ICommand _movementOnXAxisCommand;
    private ICommand _movementOnYAxisCommand;
    private void Start()
    {
        _movementInvoker = new MovementInvoker();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _movementOnXAxisCommand = new MoveOnXAxisCommand(_cube);
            _movementInvoker.AddCommand(_movementOnXAxisCommand);
        }

        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _movementOnYAxisCommand = new MoveOnYAxisCommand(_cube);
            _movementInvoker.AddCommand(_movementOnYAxisCommand);
        }

        else if (Input.GetKeyDown(KeyCode.Z))
        {
            _movementInvoker.UndoCommand();
        }
    }
}
