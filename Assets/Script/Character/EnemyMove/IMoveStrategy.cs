using UnityEngine;

public interface IMoveStrategy
{
    Vector3 Move(Vector3 position, float deltaTime);
}
