using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove
{
    public float moveSpeed = 5.0f;

    public PlayerMove(
         float moveSpeed)
    {
        this.moveSpeed = moveSpeed;
    }

    public Vector3 Right(Vector3 position, float deltaTime)
    {
        return position + Vector3.right * moveSpeed * deltaTime;
    }

    public Vector3 Left(Vector3 position, float deltaTime)
    {
        return position + Vector3.left * moveSpeed * deltaTime;
    }

    public Vector3 Up(Vector3 position, float deltaTime)
    {
        return position + Vector3.up * moveSpeed * deltaTime;
    }

    public Vector3 Down(Vector3 position, float deltaTime)
    {
        return position + Vector3.down * moveSpeed * deltaTime;
    }   
}