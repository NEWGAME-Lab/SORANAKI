using UnityEngine;

public class EnemyMoveController : MonoBehaviour
{
    private IMoveStrategy currentMove;

    public void SetMove(IMoveStrategy move)
    {
        currentMove = move;
    }

    public Vector3 Move(Vector3 position, float deltaTime)
    {
        Vector3 newposition;
        // 現在の移動方法を使って移動位置を計算
        newposition = currentMove.Move(position, deltaTime);
        // 結果を返す
        return newposition;
    }
}
