using UnityEngine;
using System;

public class MoneyState : MonoBehaviour
{
    [SerializeField] private int money = 0;
    public event Action<RewardMoneyData> moneystructchange;

    private void Awake()
    {
        var states = FindObjectsByType<MoneyState>();
        if (states.Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    public int GetMoney() => money;

    public bool Addmoney(int rewardMoney)
    {
        if (rewardMoney < 0)
        {
            return false;
        }

        money += rewardMoney;
        return true;
    }

    public bool subtractmoney(int price)
    {
        if (price < 0 || money < price)
        {
            return false;
        }

        money -= price;
        return true;
    }

    public void ApplyReward(RewardMoneyData reward)
    {
        if (Addmoney(reward.RewardMoney))
        {
            moneystructchange?.Invoke(reward);
        }
    }
}
