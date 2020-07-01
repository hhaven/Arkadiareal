using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattlestation;
    public Transform enemyBattlestation2;
    public Transform enemyBattlestation3;

    EnemyUnit playerUnit;
    EnemyUnit enemyUnit;
    EnemyUnit enemyUnit2;
    EnemyUnit enemyUnit3;

    public Text dialogueText;

    private readonly Random _random = new Random();
    int randomNumber;

    public BattleHUD playerHUD;


    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<EnemyUnit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattlestation);
        enemyUnit = enemyGO.GetComponent<EnemyUnit>();

        randomNumber = Random.Range(0, 6);

        if (randomNumber <= 2)
        {
            GameObject enemyGO2 = Instantiate(enemyPrefab, enemyBattlestation2);
            enemyUnit2 = enemyGO2.GetComponent<EnemyUnit>();
            dialogueText.text = "A " + enemyUnit.unitName + " and a " + enemyUnit2.unitName + " want to fight!";

        }

        if (randomNumber == 3)
        {
            GameObject enemyGO2 = Instantiate(enemyPrefab, enemyBattlestation2);
            enemyUnit2 = enemyGO2.GetComponent<EnemyUnit>();
            GameObject enemyGO3 = Instantiate(enemyPrefab, enemyBattlestation3);
            enemyUnit3 = enemyGO3.GetComponent<EnemyUnit>();
            dialogueText.text = "A " + enemyUnit.unitName + ", " + enemyUnit2.unitName + " and a " + enemyUnit3.unitName + " want to fight!";

        }
        else if (randomNumber >= 4)
        {
            dialogueText.text = "A " + enemyUnit.unitName + " wants to fight!";
        }

        playerHUD.SetHUD(playerUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();


    }

    void PlayerTurn()
    {
        dialogueText.text = "Player turn";
    }

}
