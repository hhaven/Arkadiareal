using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
  /*  GameObject shopItemPrefab;

    [Header("List of items sold")]
    [SerializeField] private ItemShop[] itemShop;

    [Header("References")]
    [SerializeField] private Transform shopContainer;

    private void Start()
    {
        PopulateShop();
    }

    private void PopulateShop()
    {
        for(int i = 0; i < itemShop.Length; i++)
        {
            ItemShop si = itemShop[i];
            GameObject itemObject = Instantiate(shopItemPrefab, shopContainer);


            itemObject.GetComponent<Button>.onClick.AddListener(() => OnButtonClick());

            itemObject.transform.GetChild(1).GetComponent<Image>().sprite = si.sprite;

            itemObject.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = si.itemName ;
        
        
        }
    }

    private void OnButtonClick(ItemShop item)
    {
        Debug.Log(item.name);
    }*/

}
