using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 責務:データを並べて保存するだけ(検索は DataTableSearch が行う)。
/// </summary>
public abstract class TableAsset<T> : ScriptableObject where T : IHasId
{
    [SerializeField] private List<T> entries = new List<T>();
    public IReadOnlyList<T> Entries => entries;
}
