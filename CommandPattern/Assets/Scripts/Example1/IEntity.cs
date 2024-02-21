using UnityEngine;

public interface IEntity 
{
    Transform Transform { get; }
    void MoveFromTo(Vector3 startPosition , Vector3 endPosition);
}
