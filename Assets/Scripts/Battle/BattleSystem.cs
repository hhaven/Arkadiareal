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

    EnemyUnit playerUnit;
    EnemyUnit enemyUnit;

    public Text dialogueText;

    private readonly Random _random = new Random();
    int randomNumber;
  

    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<EnemyUnit>();
        
        
        


        randomNumber = Random.Range(0, 2);

        if(randomNumber == 0)
        {
            GameObject enemyGO = Instantiate(enemyPrefab, enemyBattlestation);
            enemyUnit = enemyGO.GetComponent<EnemyUnit>();

        }

        dialogueText.text = enemyUnit.unitName;
    }

}
