using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 「検索 → 判断 → 計上」の一連の動きを確認するチェック本体(Unity非依存のロジック部分)。
/// </summary>
public static class ItemHandSliceCheck
{
    public static List<ItemData> SampleData() => new List<ItemData>
    {
        new ItemData("item_potion", "回復薬", 50, true),   // 複数所持OK
        new ItemData("item_key",    "古い鍵", 0,  false),  // 1個だけ
    };

    public static bool Run(IEnumerable<ItemData> table)
    {
        var search = new DataTableSearch<ItemData>(table);
        var state = new ItemState();
        var counter = new ItemHandCounter(search, state);

        int added = 0;
        state.OnAdded += _ => added++;

        int fail = 0;
        void Expect(bool ok, string label)
        {
            if (!ok) fail++;
            Debug.Log($"[{(ok ? "PASS" : "FAIL")}] {label}");
        }

        // 存在しないID・null
        Expect(counter.Give("item_nothing") == GiveResult.UnknownId, "存在しないID → UnknownId");
        Expect(counter.Give(null) == GiveResult.UnknownId, "null → UnknownId");
        Expect(state.Items.Count == 0, "失敗時は所持品が増えない");

        // 複数所持OKのアイテム
        Expect(counter.Give("item_potion") == GiveResult.Success, "回復薬 1個目 → Success");
        Expect(counter.Give("item_potion") == GiveResult.Success, "回復薬 2個目 → Success");
        Expect(state.Count("item_potion") == 2, "回復薬の所持数が2");

        // 1個だけのアイテム
        Expect(counter.Give("item_key") == GiveResult.Success, "鍵 1個目 → Success");
        Expect(state.Has("item_key"), "鍵を所持している");
        Expect(counter.Give("item_key") == GiveResult.AlreadyOwned, "鍵 2個目 → AlreadyOwned");
        Expect(state.Count("item_key") == 1, "拒否後も鍵の所持数は1");

        // 通知
        Expect(added == 3, "OnAdded は成功した3回だけ発火");

        Debug.Log(fail == 0 ? "=== ALL PASS ===" : $"=== {fail} FAILED ===");
        return fail == 0;
    }
}
