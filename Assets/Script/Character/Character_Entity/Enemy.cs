using UnityEngine;

public class Enemy : Character
{
    private EnemyMove enemyMove;
    [SerializeField] private float moveDistance = 5f;
    [SerializeField] private float moveSpeed = 2f;
    bool isMovingRight = true;

    protected void Awake()
    {
        enemyMove = new EnemyMove(transform.position, moveDistance, moveSpeed);
    }
    protected void Update()
    {
        // Example movement logic (replace with your own)
        float deltaTime = Time.deltaTime;
        Vector3 newPosition = transform.position;
        
        if (!enemyMove.IsWithinBounds(newPosition))
        {
            isMovingRight = !isMovingRight;
        }

        if (isMovingRight)
        {
            newPosition = enemyMove.RightMove(newPosition, deltaTime);
        } 
        else
        {
            newPosition = enemyMove.LeftMove(newPosition, deltaTime);
        }

        transform.position = newPosition;
    }
}
