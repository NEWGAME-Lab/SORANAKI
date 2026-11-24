/// <summary>
/// 責務:IDを受け取ってテーブルから検索し、そのアイテムを持ってよいか判断して、所持品に計上する。
/// </summary>
public class ItemHandCounter
{
    private readonly DataTableSearch<ItemData> itemSearch;
    private readonly ItemState itemState;

    public ItemHandCounter(DataTableSearch<ItemData> itemSearch, ItemState itemState)
    {
        this.itemSearch = itemSearch;
        this.itemState = itemState;
    }

    /// <summary>検索 → 所持してよいか判断 → 所持品に追加。結果を返す。</summary>
    public GiveResult Give(string itemId)
    {
        if (!itemSearch.IDSearch(itemId, out var item))
            return GiveResult.UnknownId;

        var result = Permit(item);
        if (result != GiveResult.Success)
            return result;

        itemState.Add(item.Id);
        return GiveResult.Success;
    }

    /// <summary>所持してよいかの確認(状態は変えない)。</summary>
    private GiveResult Permit(ItemData item)
    {
        if (!item.AllowDuplicate && itemState.Has(item.Id))
            return GiveResult.AlreadyOwned;

        return GiveResult.Success;
    }
}
