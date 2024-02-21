using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputReader), typeof(CommandProcessor))]
public class Entity : MonoBehaviour , IEntity
{
    private InputReader _inputReader;
    private CommandProcessor _commandProcessor;

    private Transform _transform;
    public Transform Transform => _transform;

    private void Awake()
    {
        _transform = transform;
        _inputReader = GetComponent<InputReader>();
        _commandProcessor = GetComponent<CommandProcessor>();
    }

    private void Update()
    {
        var direction = _inputReader.ReadInput();

        if (direction != Vector3.zero)
        {
            var moveCommand = new MoveCommand(this , direction);
            _commandProcessor.ExecuteCommand(moveCommand);
        }

        if (_inputReader.ReadUndo())
        {
            _commandProcessor.Undo();
        }

        float scaleDirection = _inputReader.ReadScale();

        if(scaleDirection != 0f)
            _commandProcessor.ExecuteCommand(new ScaleCommand(this , scaleDirection));
    }

    public void MoveFromTo(Vector3 startPosition, Vector3 endPosition)
    {
        throw new System.NotImplementedException();
    }
}
