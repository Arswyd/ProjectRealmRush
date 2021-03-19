using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;

    [SerializeField] int currentBalance;

    private void Awake()
    {
        currentBalance = startingBalance;
    }

    public int CurrentBalance { get { return currentBalance; } }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);

        if(currentBalance <0)
        {
            //Lose the game
            ReloadScene();
        }
    }

    // TODO - Reload not working proparely
    void ReloadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}
