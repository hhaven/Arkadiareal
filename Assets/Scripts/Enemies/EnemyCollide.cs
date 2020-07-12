using UnityEngine;

public class EnemyCollide : MonoBehaviour
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

        Destroy(this.gameObject);
        
        //Player.SetActive(false);
    }

   

}
