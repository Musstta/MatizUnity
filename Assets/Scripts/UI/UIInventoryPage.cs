using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryPage : MonoBehaviour
{ 
    [SerializeField]
    private ItemUIScript itemPrefab;

    [SerializeField]
    private RectTransform contentPanel;

    List<ItemUIScript> listOfUIItems = new List<ItemUIScript>();


    public void InitializeInventoryUI(int inventorysize) 
    {
        for (int i = 0; i < inventorysize; i++) 
        {
           ItemUIScript uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            uiItem.transform.SetParent(contentPanel);
            listOfUIItems.Add(uiItem);
        }

    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide() 
    {
        gameObject.SetActive(false);
    }

}
