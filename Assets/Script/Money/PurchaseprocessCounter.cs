using UnityEngine;
using System;

[Serializable]
public struct ItemData //: IHasId
{
    [SerializeField] private string itemId;
    [SerializeField] private string itemName;
    [SerializeField] private int price;

    //public string Id => itemId;
    public string ItemId => itemId;
    public string ItemName => itemName;
    public int Price => price;
}

public class PurchaseprocessCounter : MonoBehaviour
{
    [SerializeField] private MoneyState moneyState;
    //private DataTableSearch<ItemData> itemSearch;

    //public void Initialize(DataTableSearch<ItemData> search, MoneyState state = null)
    //{
        //itemSearch = search;
        //if (state != null)
        //{
            //moneyState = state;
        //}
    //}

    public bool Purchase(string itemId)
    {
        //if (itemSearch == null || moneyState == null)
        //{
            //return false;
        //}
        //if (!itemSearch.IDSearch(itemId, out ItemData item))
        //{
            //return false;
        //}

        //return moneyState.subtractmoney(item.Price);

        return false;
    }

    public bool Purchase(int itemId)
    {
        return Purchase(itemId.ToString());
    }
}
