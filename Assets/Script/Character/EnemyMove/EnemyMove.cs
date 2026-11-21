using UnityEngine;

public class EnemyMove
{
    private readonly float leftLimit;
    private readonly float rightLimit;
    private readonly float moveSpeed;

    public EnemyMove(
        Vector3 startPosition,
        float moveDistance,
        float moveSpeed)
    {
        leftLimit = startPosition.x - moveDistance;
        rightLimit = startPosition.x + moveDistance;
        this.moveSpeed = moveSpeed;
    }

    public bool IsWithinBounds(Vector3 position)
    {
        return position.x >= leftLimit && position.x <= rightLimit;
    }

    public Vector3 RightMove(Vector3 position, float deltaTime)
    {

        // Example movement logic (replace with your own)
        return position + Vector3.right * deltaTime;
    }

    public Vector3 LeftMove(Vector3 position, float deltaTime)
    {
        // Example movement logic (replace with your own)
        return position + Vector3.left * deltaTime;
    }


}
