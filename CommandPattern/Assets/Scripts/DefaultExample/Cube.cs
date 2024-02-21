using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Receiver
/// </summary>
public class Cube : MonoBehaviour
{
    private Vector3 _movementValue;
    private Vector3 _currentPos;
    public void MoveOnYAxis()
    {
        _movementValue = new Vector3(0, 5, 0);

        _currentPos = transform.position;

        transform.position += _movementValue;
    }

    public void MoveOnXAxis()
    {
        _movementValue = new Vector3(5,0,0);

        _currentPos = transform.position;

        transform.position += _movementValue;
    }

    public void MoveBack()
    {
        transform.position = _currentPos;
    }
}
