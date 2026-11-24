using UnityEngine;
using System.Collections.Generic;

public class MoneyVerifyRunner : MonoBehaviour
{
    [SerializeField] private MoneyState moneyState;
    [SerializeField] private PurchaseprocessCounter purchaseCounter;
    [SerializeField] private int initialMoney = 1000;

    private void Start()
    {
        if (moneyState == null) moneyState = GetComponent<MoneyState>();
        if (purchaseCounter == null) purchaseCounter = GetComponent<PurchaseprocessCounter>();

        var sampleItems = new List<ItemData>
        {
            new ItemData("ITEM_01", "回復薬", 400, true),
            new ItemData("ITEM_02", "高級装備", 99999, false)
        };

        var search = new DataTableSearch<ItemData>(sampleItems);
        purchaseCounter.Initialize(search, moneyState);

        moneyState.moneystructchange += HandleRewardChanged;

        Debug.Log($"[初期]　所持金={moneyState.GetMoney()} (期待値: {initialMoney}) ");

        var reward = new RewardMoneyData("ENEMY_01", 500);
        moneyState.ApplyReward(reward);
        Debug.Log($"[報酬+500後] 所持金={moneyState.GetMoney()}");

        bool ok = purchaseCounter.Purchase("ITEM_01");
        Debug.Log($"[購入 ITEM_01 (400)] 成否={ok}, 所持金={moneyState.GetMoney()}");

        bool noMoney = purchaseCounter.Purchase("ITEM_02");
        Debug.Log($"[購入 ITEM_02 (残高不足)] 成否={noMoney}, 所持金={moneyState.GetMoney()}");

        bool notFound = purchaseCounter.Purchase("UNKNOWN_ID");
        Debug.Log($"[購入 UNKNOWN_ID] 成否={notFound}, 所持金={moneyState.GetMoney()}");

        moneyState.moneystructchange -= HandleRewardChanged;
    }

    private void HandleRewardChanged(RewardMoneyData reward)
    {
        Debug.Log($"[イベント発火] EnemyId = {reward.EnemyId}, RewardMoney={reward.RewardMoney}");
    }
    
}
