using UnityEngine;
/// <summary>
/// 攻撃が当たった敵の情報を保持する
/// </summary>
public class HitWeapon : MonoBehaviour
{
    [SerializeField]private Player player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Debug.Log($"命中した敵：{enemy.GetType().Name}");
        if (enemy == null)
        {
            return;
        }

        // Playerから与えるダメージを取得
        int damage = player.DealtDamage(1000); // ここで武器のダメージを指定する（例: 10）
        Debug.Log($"与えるダメージ：{damage}");
        // Enemyにダメージを与える
        enemy.TakeDamage(damage); // ここで武器のダメージを指定する（例: 10）
    }


}
