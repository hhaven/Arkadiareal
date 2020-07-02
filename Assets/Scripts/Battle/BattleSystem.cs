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
            dialogueText.text = "Enemies want to fight!";

        }

        else if (randomNumber == 3)
        {
            GameObject enemyGO2 = Instantiate(enemyPrefab, enemyBattlestation2);
            enemyUnit2 = enemyGO2.GetComponent<EnemyUnit>();
            GameObject enemyGO3 = Instantiate(enemyPrefab, enemyBattlestation3);
            enemyUnit3 = enemyGO3.GetComponent<EnemyUnit>();
            dialogueText.text = "Enemies want to fight!";

        }
        else if (randomNumber >= 4)
        {
            dialogueText.text = "An enemy wants to fight!";
        }

        playerHUD.SetHUD(playerUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();


    }

    IEnumerator PlayerAttack()
    {
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
        yield return new WaitForSeconds(2f);
        if (isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }

    void EndBattle()
    {
        if(state == BattleState.WON)
        {
            dialogueText.text = "you won the battle";
        }
        else if (state == BattleState.LOST)
        {
            dialogueText.text = "you lost";
        }
    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyUnit.unitName + "attacks";
        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

        playerHUD.SetHP(playerUnit.currentHP);
        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }

    void PlayerTurn()
    {
        dialogueText.text = "Player turn";
    }

    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;
        StartCoroutine(PlayerAttack());
    }

}
