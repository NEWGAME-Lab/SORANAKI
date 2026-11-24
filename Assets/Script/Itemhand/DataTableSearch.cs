using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 責務:IDを受け取ってテーブルから検索し、データを返す(全Counterで共通)
/// </summary>
public class DataTableSearch<T> where T : IHasId
{
    private readonly Dictionary<string, T> map = new Dictionary<string, T>();

    public DataTableSearch(IEnumerable<T> entries)
    {
        foreach (var e in entries)
        {
            if (map.ContainsKey(e.Id))
            {
                Debug.LogWarning($"ID重複: {e.Id}");
                continue;
            }
            map.Add(e.Id, e);
        }
    }

    /// <summary>IDで検索して、見つかったかどうかと結果を返す。</summary>
    public bool IDSearch(string id, out T data)
    {
        data = default;
        return id != null && map.TryGetValue(id, out data);
    }

    public bool Contains(string id) => id != null && map.ContainsKey(id);
}
