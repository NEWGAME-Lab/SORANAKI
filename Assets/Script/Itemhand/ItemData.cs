using System;
using UnityEngine;

/// <summary>
/// アイテムのマスターデータ(検索される側)。
/// </summary>
[Serializable]
public struct ItemData : IHasId
{
    [SerializeField] private string id;
    [SerializeField] private string itemName;
    [SerializeField] private int price;
    [SerializeField] private bool allowDuplicate; // 2個以上持ってよいか

    public string Id => id;
    public string ItemName => itemName;
    public int Price => price;
    public bool AllowDuplicate => allowDuplicate;

    public ItemData(string id, string itemName, int price, bool allowDuplicate)
    {
        this.id = id;
        this.itemName = itemName;
        this.price = price;
        this.allowDuplicate = allowDuplicate;
    }
}
