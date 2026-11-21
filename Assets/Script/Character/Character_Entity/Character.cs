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

    public virtual void TakeDamage(int damage)
    {
        // ダメージ処理
    }

    protected virtual void Die()
    {
        // 死亡処理
    }
   
}
