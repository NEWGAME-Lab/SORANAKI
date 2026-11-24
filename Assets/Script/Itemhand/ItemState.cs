using System;
using System.Collections.Generic;

/// <summary>
/// 責務:プレイヤーの所持アイテムを管理する(ItemData や検索は知らない)。
/// 個数をIDごとに数える。
/// </summary>
public class ItemState
{
    private readonly Dictionary<string, int> counts = new Dictionary<string, int>();

    /// <summary>アイテムが追加されたときに通知(UI用)。</summary>
    public event Action<string> OnAdded;

    public bool Has(string id) => Count(id) > 0;

    public int Count(string id)
    {
        if (id == null) return 0;
        return counts.TryGetValue(id, out var n) ? n : 0;
    }

    public void Add(string id)
    {
        if (id == null) return;
        counts[id] = Count(id) + 1;
        OnAdded?.Invoke(id);
    }

    public IReadOnlyDictionary<string, int> Items => counts;
}
