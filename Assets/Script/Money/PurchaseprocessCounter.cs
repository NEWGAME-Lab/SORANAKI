using UnityEngine;
using System;

public class PurchaseprocessCounter : MonoBehaviour
{
    [SerializeField] private MoneyState moneyState;
    private DataTableSearch<ItemData> itemSearch;

    public void Initialize(DataTableSearch<ItemData> search, MoneyState state = null)
    {
        itemSearch = search;
        if (state != null)
        {
            moneyState = state;
        }
    }

    public bool Purchase(string itemId)
    {
        if (itemSearch == null || moneyState == null)
        {
            return false;
        }
        if (!itemSearch.IDSearch(itemId, out ItemData item))
        {
            return false;
        }

        return moneyState.subtractmoney(item.Price);

    }

    public bool Purchase(int itemId)
    {
        return Purchase(itemId.ToString());
    }
}
