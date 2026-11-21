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
        // 現在の移動方法を使って移動位置を計算
        // 結果を返す
        return position;
    }
}
