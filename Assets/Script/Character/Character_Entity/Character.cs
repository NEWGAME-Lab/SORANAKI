using UnityEngine;

public class Character : MonoBehaviour
{
    public int CharacterID { get; protected set; }
    public int CurrentHP { get; protected set; }
    protected string CharacterName;
    protected CharacterStatus status;
    public bool IsDead => CurrentHP <= 0;

    public virtual void Initialize(CharacterData characterData)
    {
        // CharacterIDから定義データを取得
        // CurrentHPを初期化
        CharacterName = characterData.name;
        status = characterData.status;
        CurrentHP = status.hp;
        Debug.Log($"Character Initialized: ID={CharacterID}, Name={CharacterName}, HP={CurrentHP}, Attack={status.attack}, Defense={status.defense}");
    }
    /// <summary>
    /// 基礎的なダメージを受け取って、自身の状態に併せて計算し直し反映する
    /// </summary>
    /// <param name="damage"></param>
    public virtual void TakeDamage(int damage)
    {
        // ダメージ処理
        int finalDamage = Mathf.Max(0, damage - status.defense);
        CurrentHP = Mathf.Max(0, CurrentHP - finalDamage);
        if(CurrentHP <= 0)
        {
            Die();
        }

    }

    /// <summary>
    /// 死亡処理（一旦消えるだけ）
    /// </summary>
    protected virtual void Die()
    {
        // 死亡処理
        Destroy(gameObject);
    }
   
}
