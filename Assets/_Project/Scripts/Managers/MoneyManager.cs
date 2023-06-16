using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] private int currentBalance; // Current amount of money player has to spend
    [SerializeField] private GameObject uiObject; // UI object displaying current balance

    private TextMeshProUGUI tmp_moneyText; // TMP component of UI object

    public static MoneyManager instance; // Singleton instance

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(this);
        }

        tmp_moneyText = uiObject.GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddMoney(int amount)
    {
        currentBalance += amount;
        UpdateUI();
    }

    public void RemoveMoney(int amount)
    {
        currentBalance -= amount;
        UpdateUI();
    }

    public int GetBalance()
    {
        return currentBalance;
    }

    private void UpdateUI()
    {
        tmp_moneyText.text = "Current Money: " + currentBalance;
    }
}
