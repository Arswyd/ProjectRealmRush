using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;

    int currentBalance;
    public int CurrentBalance { get { return currentBalance; } }

    [SerializeField] TextMeshProUGUI displayBalance;

    int currentSceneIndex;

    private void Awake()
    {
        currentBalance = startingBalance;
    }

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == 1)
        {
            UpdateDisplay();
        }
    }

    void Update()
    {
        if (currentSceneIndex == 0 && Input.GetKeyDown(KeyCode.Space))
        {
            LoadBattleScene();
        }
        if (currentSceneIndex == 2 && Input.GetKeyDown(KeyCode.R))
        {
            LoadBattleScene();
        }
    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();
        if (currentBalance >= 500)
        {
            //Win the game
            LoadWinScene();
        }
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateDisplay();

        if (currentBalance <0)
        {
            //Lose the game
            LoadBattleScene();
        }
    }

    void UpdateDisplay()
    {
        displayBalance.text = "Gold: " + currentBalance;
    }

    void LoadBattleScene()
    {
        SceneManager.LoadScene(1);
    }

    void LoadWinScene()
    {
        SceneManager.LoadScene(2);
    }

}
