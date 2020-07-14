using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WAIT, TARGET, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattlestation;
    public Transform enemyBattlestation2;
    public Transform enemyBattlestation3;
    public Transform BossBattleStation;

    GameObject player;

    PlayerUnit playerUnit;
    EnemyUnit enemyUnit;
    EnemyUnit enemyUnit2;
    EnemyUnit enemyUnit3;

    public Text dialogueText;

    public int selection;
    public int deadenemycount;

    private readonly Random _random = new Random();
    int randomNumber;

    public BattleHUD playerHUD;

    public GameObject panel;


    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerInfo");
        panel = GameObject.Find("Main");
        state = BattleState.START;
        if (player.GetComponent<PlayerStats>().isbossbattle)
        {

            randomNumber = -1;
            StartCoroutine(SetupBossBattle());
        }
        else
        {
            StartCoroutine(SetupBattle());
        }
    }

    IEnumerator SetupBossBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<PlayerUnit>();


        GameObject enemyGO = Instantiate(enemyPrefab, BossBattleStation);
        enemyUnit = enemyGO.GetComponent<EnemyUnit>();

        yield return new WaitForEndOfFrame();
        playerHUD.SetHUD(playerUnit);

        dialogueText.text = "Defeat the boss!";


        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator SetupBattle()
    {

        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<PlayerUnit>();
        

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattlestation);
        enemyUnit = enemyGO.GetComponent<EnemyUnit>();

        randomNumber = Random.Range(0, 7);

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
        yield return new WaitForEndOfFrame();
        playerHUD.SetHUD(playerUnit);


        yield return new WaitForSeconds(2f);
        
        state = BattleState.PLAYERTURN;
        PlayerTurn();


    }


    public void Selected1()
    {
        if (state == BattleState.TARGET)
        {
            selection = 1;
            state = BattleState.PLAYERTURN;
        }
    }
    public void Selected2()
    {
        if (state == BattleState.TARGET)
        {
            selection = 2;
            state = BattleState.PLAYERTURN;
        }
    }
    public void Selected3()
    {
        if (state == BattleState.TARGET)
        {
            selection = 3;
            state = BattleState.PLAYERTURN;
        }
    }
    IEnumerator PlayerAttack()
    {
        if (state == BattleState.PLAYERTURN)
        {
            if (player.GetComponent<PlayerStats>().isbossbattle)
            {

                bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
                state = BattleState.WAIT;
                yield return new WaitForEndOfFrame();
                if (isDead)
                {
                    Destroy(GameObject.Find("BossBattleStation"));
                    state = BattleState.WON;
                    EndBattle();
                }
                else
                {
                    state = BattleState.ENEMYTURN;
                    StartCoroutine(EnemyTurn());
                }
            }
            else if (randomNumber <= 2)
            {
                dialogueText.text ="Tap on the enemy you want to attack";
                state = BattleState.TARGET;
                while (state == BattleState.TARGET)
                {
                    yield return new WaitForEndOfFrame();
                }
                
                
                switch (selection)
                {
                    case 1:
                        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
                        if (isDead)
                        {
                            deadenemycount += 1;
                            Destroy(GameObject.Find("enemyBattleStation"));
                            if (deadenemycount == 2)
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
                        else
                        {
                            state = BattleState.ENEMYTURN;
                            StartCoroutine(EnemyTurn());
                        }
                        break;
                    case 2:
                        bool isDead2 = enemyUnit2.TakeDamage(playerUnit.damage);
                        if (isDead2)
                        {
                            deadenemycount += 1;
                            Destroy(GameObject.Find("enemyBattleStation2"));
                            if (deadenemycount == 2)
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
                        else
                        {
                            state = BattleState.ENEMYTURN;
                            StartCoroutine(EnemyTurn());
                        }
                        break;

                }
            }
            else if (randomNumber == 3)
            {
                string myString = randomNumber.ToString();
                dialogueText.text = myString + " Tap on the enemy you want to attack";
                state = BattleState.TARGET;
                while (state == BattleState.TARGET)
                {
                    yield return new WaitForEndOfFrame();
                }


                switch (selection)
                {
                    case 1:
                        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
                        dialogueText.text = enemyUnit.unitName + " died";
                        if (isDead)
                        {
                            deadenemycount += 1;
                            Destroy(GameObject.Find("enemyBattleStation"));
                            if (deadenemycount == 3)
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
                        else
                        {
                            state = BattleState.ENEMYTURN;
                            StartCoroutine(EnemyTurn());
                        }
                        break;
                    case 2:
                        bool isDead2 = enemyUnit2.TakeDamage(playerUnit.damage);
                        if (isDead2)
                        {
                            deadenemycount += 1;
                            Destroy(GameObject.Find("enemyBattleStation2"));
                            if (deadenemycount == 3)
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
                        else
                        {
                            state = BattleState.ENEMYTURN;
                            StartCoroutine(EnemyTurn());
                        }
                        break;
                    case 3:
                        bool isDead3 = enemyUnit3.TakeDamage(playerUnit.damage);
                        if (isDead3)
                        {
                            deadenemycount += 1;
                            Destroy(GameObject.Find("enemyBattleStation3"));
                            if (deadenemycount == 3)
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
                        else
                        {
                            state = BattleState.ENEMYTURN;
                            StartCoroutine(EnemyTurn());
                        }
                        break;

                }
            }
            else if (randomNumber >= 4)
            {
                string myString = randomNumber.ToString();
                dialogueText.text = myString;
                bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
                state = BattleState.WAIT;
                yield return new WaitForEndOfFrame();
                if (isDead)
                {
                    Destroy(GameObject.Find("enemyBattleStation"));
                    state = BattleState.WON;
                    EndBattle();
                }
                else
                {
                    state = BattleState.ENEMYTURN;
                    StartCoroutine(EnemyTurn());
                }
            }

            
            
        }
    }
    // detects clicked enemy
    

    void EndBattle()
    {
        if(state == BattleState.WON)
        {
            dialogueText.text = "you won the battle";
            StartCoroutine(ReceiveExperience());
            if (player.GetComponent<PlayerStats>().maxXP == player.GetComponent<PlayerStats>().currentXP)
            {
                player.GetComponent<PlayerStats>().LevelUp();
                dialogueText.text = "you leveled up!";
            }
            
            StartCoroutine(DestroyBattle());


        }
        else if (state == BattleState.LOST)
        {
            dialogueText.text = "you lost";
            StartCoroutine(DestroyBattle());
        }
        

        

    }

    IEnumerator ReceiveExperience()
    {
        yield return new WaitForSeconds(1F);
        if (player.GetComponent<PlayerStats>().isbossbattle)
        {
            dialogueText.text = "You defeated the boss!. Earned " + (enemyUnit.XP) + " experience points";
            player.GetComponent<PlayerStats>().currentXP += enemyUnit.XP;

        }
        else if (randomNumber <= 2)
        {
            dialogueText.text = "you won " + (enemyUnit.XP + enemyUnit2.XP) + " experience points";
            player.GetComponent<PlayerStats>().currentXP += enemyUnit.XP+enemyUnit2.XP;
          
        }
        else if (randomNumber == 3)
        {
            dialogueText.text = "you won " + (enemyUnit.XP + enemyUnit2.XP + enemyUnit3.XP) + " experience points";
            player.GetComponent<PlayerStats>().currentXP += enemyUnit.XP + enemyUnit2.XP + enemyUnit3.XP;
            
        }
        else if (randomNumber >= 4)
        {
            dialogueText.text = "you won " + (enemyUnit.XP) + " experience points";
            player.GetComponent<PlayerStats>().currentXP += enemyUnit.XP;
            
        }



        if (player.GetComponent<PlayerStats>().maxXP <= player.GetComponent<PlayerStats>().currentXP)
        {
            player.GetComponent<PlayerStats>().LevelUp();
            dialogueText.text = "Congratulations you leveled up!";
        }

    }

    IEnumerator DestroyBattle()
    {
        
        yield return new WaitForSeconds(2f);
        panel.transform.GetChild(0).gameObject.SetActive(true);
        //GameObject playercontroller = GameObject.FindGameObjectWithTag("Player");
        GameObject joystick = GameObject.FindGameObjectWithTag("GameController");
        joystick.SetActive(false);
        //playercontroller.GetComponent<PlayerController>().enabled = false;
        joystick.SetActive(true);
        //playercontroller.GetComponent<PlayerController>().enabled = true;*/
        //GameObject.FindGameObjectWithTag("GameScreen").SetActive(true);

        GameObject.Find("Player").GetComponent<PlayerController>().acceptmovement = false;
        Input.ResetInputAxes();
        if (randomNumber == -1 || state == BattleState.LOST)
        {
            dialogueText.text = "Going back to town...";
            if (randomNumber == -1 && state == BattleState.WON)
            {
                if(GameObject.Find("enemyPrefab(Clone)").GetComponent<EnemyUnit>().boss == 1 && player.GetComponent<PlayerStats>().bossdefeated == 0)
                {
                    player.GetComponent<PlayerStats>().bossdefeated = 1;
                }
                else if (GameObject.Find("enemyPrefab(Clone)").GetComponent<EnemyUnit>().boss == 2 && player.GetComponent<PlayerStats>().bossdefeated == 0)
                {
                    player.GetComponent<PlayerStats>().bossdefeated = 2;
                }
                else if (GameObject.Find("enemyPrefab(Clone)").GetComponent<EnemyUnit>().boss == 3 && player.GetComponent<PlayerStats>().bossdefeated == 0)
                {
                    player.GetComponent<PlayerStats>().bossdefeated = 3;
                }
            }
            SceneManager.LoadScene("Town");
        }
        else {
            Destroy(GameObject.FindGameObjectWithTag("battle"));
        }
        
    }

    IEnumerator EnemyTurn()
    {
        if (player.GetComponent<PlayerStats>().isbossbattle)
        {
            if (enemyUnit.currentHP >= 1)
            {
                dialogueText.text = enemyUnit.unitName + " attacks";
                yield return new WaitForSeconds(1f);
                bool isDead = playerUnit.TakeDamage(enemyUnit.damage);
                if (isDead)
                {
                    state = BattleState.LOST;
                    EndBattle();
                }
            }
            playerHUD.SetHP((float)playerUnit.currentHP);
            yield return new WaitForSeconds(1f);

            if (state != BattleState.LOST)
            {
                state = BattleState.PLAYERTURN;
                PlayerTurn();
            }
        }

        else if (randomNumber <= 2) //two enemies
        {
            if (enemyUnit.currentHP >= 1)
            {
                dialogueText.text = enemyUnit.unitName + " attacks";
                yield return new WaitForSeconds(1f);
                bool isDead = playerUnit.TakeDamage(enemyUnit.damage);
                if (isDead)
                {
                    state = BattleState.LOST;
                    EndBattle();
                }
            }
            if (enemyUnit2.currentHP >= 1)
            {
                dialogueText.text = enemyUnit2.unitName + " attacks";
                yield return new WaitForSeconds(1f);
                bool isDead2 = playerUnit.TakeDamage(enemyUnit2.damage);
                if (isDead2)
                {
                    state = BattleState.LOST;
                    EndBattle();
                }

            }

            playerHUD.SetHP((float)playerUnit.currentHP);
            yield return new WaitForSeconds(1f);

            if (state != BattleState.LOST)
            {
                state = BattleState.PLAYERTURN;
                PlayerTurn();
            }
        }
        
        else if (randomNumber == 3) //three enemies
        {
            if (enemyUnit.currentHP >= 1)
            {
                dialogueText.text = enemyUnit.unitName + " attacks";
                yield return new WaitForSeconds(1f);
                bool isDead = playerUnit.TakeDamage(enemyUnit.damage);
                if (isDead)
                {
                    state = BattleState.LOST;
                    EndBattle();
                }
            }
            if (enemyUnit2.currentHP >= 1)
            {
                dialogueText.text = enemyUnit2.unitName + " attacks";
                yield return new WaitForSeconds(1f);
                bool isDead2 = playerUnit.TakeDamage(enemyUnit2.damage);
                if (isDead2)
                {
                    state = BattleState.LOST;
                    EndBattle();
                }

            }
            if (enemyUnit3.currentHP >= 1)
            {
                dialogueText.text = enemyUnit3.unitName + " attacks";
                yield return new WaitForSeconds(1f);
                bool isDead3 = playerUnit.TakeDamage(enemyUnit3.damage);
                if (isDead3)
                {
                    state = BattleState.LOST;
                    EndBattle();
                }

            }

            playerHUD.SetHP((float)playerUnit.currentHP);
            yield return new WaitForSeconds(1f);

            if (playerUnit.currentHP != 0)
            {
                state = BattleState.PLAYERTURN;
                PlayerTurn();
            }
        }

        else //one enemy
        {
            if (enemyUnit.currentHP >= 1)
            {
                dialogueText.text = enemyUnit.unitName + " attacks";
                yield return new WaitForSeconds(1f);
                bool isDead = playerUnit.TakeDamage(enemyUnit.damage);
                if (isDead)
                {
                    state = BattleState.LOST;
                    EndBattle();
                }
            }

            playerHUD.SetHP((float)playerUnit.currentHP);
            yield return new WaitForSeconds(1f);

            if (state != BattleState.LOST)
            {
                state = BattleState.PLAYERTURN;
                PlayerTurn();
            }
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
