using UnityEngine;

/// <summary>
/// プレイヤーのダメージを計算するクラス
/// </summary>
public class PlayerDamageCalculator 
{
   int CalculateDamage(int baseDamage,int weaponDamage)
    {
        // ダメージ計算のロジックを実装
        int dealtDamage = baseDamage + weaponDamage;
        return dealtDamage;
    }
}
