using UnityEngine;
using System;

[Serializable]
public struct RewardMoneyData// : IHasId
{
    [SerializeField] private string enemyId;
    [SerializeField] private int rewardMoney;

    //public string Id => enemyId;
    public string EnemyId => enemyId;
    public int RewardMoney => rewardMoney;

    public RewardMoneyData(string enemyId, int rewardMoney)
    {
        this.enemyId = enemyId;
        this.rewardMoney = rewardMoney;
    }
}