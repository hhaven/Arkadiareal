using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCollide : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject Player;
    public GameObject BattlePrefab;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (Panel != null)
        {

            Panel.SetActive(false);
            GameObject BATTLE = Instantiate(BattlePrefab);


        }

        GameObject.Find("PlayerInfo").GetComponent<PlayerStats>().isbossbattle = true;

        Destroy(this.gameObject);

        //Player.SetActive(false);
    }
}
