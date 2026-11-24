using UnityEngine;

public class EnemyMove :IMoveStrategy
{
    private readonly float leftLimit;
    private readonly float rightLimit;
    private readonly float moveSpeed;
    private bool isRight = true;

    public EnemyMove(
        Vector3 startPosition,
        float moveDistance,
        float moveSpeed)
    {
        leftLimit = startPosition.x - moveDistance;
        rightLimit = startPosition.x + moveDistance;
        this.moveSpeed = moveSpeed;
    }

    public Vector3 Move(Vector3 position, float deltaTime)
    {
        if (isRight && position.x >= rightLimit)
        {
            isRight = false;
        }
        else if (!isRight && position.x <= leftLimit)
        {
            isRight = true;
        }

        if (isRight)
        {
            return RightMove(position, deltaTime);
        }
        else
        {
            return LeftMove(position, deltaTime);   
        }
        // Example movement logic (replace with your own)
    }

    /// <summary>
    /// Determines whether the position is within the horizontal bounds.
    /// </summary>
    /// <param name="position">The position to evaluate.</param>
    /// <returns>`true` if the position's x-coordinate is within the bounds; otherwise, `false`.</returns>
    private bool IsWithinBounds(Vector3 position)
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
