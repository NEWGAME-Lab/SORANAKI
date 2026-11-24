using UnityEngine;

public class Enemy : Character
{
    private EnemyMove enemyMove;
    private EnemyMoveController enemyMoveController;
    [SerializeField] private float moveDistance = 5f;
    [SerializeField] private float moveSpeed = 2f;
    bool isMovingRight = true;

    protected void Awake()
    {
        enemyMove = new EnemyMove(transform.position, moveDistance, moveSpeed);
        enemyMoveController = new EnemyMoveController();
        enemyMoveController.SetMove(enemyMove);
    }
    protected void Update()
    {
        // Example movement logic (replace with your own)
        float deltaTime = Time.deltaTime;
        Vector3 newPosition = transform.position;
        newPosition = enemyMoveController.Move(newPosition, deltaTime);
        transform.position = newPosition;
    }
}
