using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class BattleController : MonoBehaviour
{
    public Canvas canvas;

    private Text playerHPText1;
    private Text playerHPText2;
    private Text playerHPText3;
    private Text enemyHPText1;
    private Text enemyHPText2;
    private Text enemyHPText3;

    private Dictionary<string, int> player1;
    private Dictionary<string, int> player2;
    private Dictionary<string, int> player3;
    private Dictionary<string, int> enemy1;
    private Dictionary<string, int> enemy2;
    private Dictionary<string, int> enemy3;

    // Use this for initialization
    void Start()
    {
        player1 = new Dictionary<string, int>()
        {
            {"maxHP", 20},
            {"hp", 20},
            {"mp", 5},
            {"attack", 10},
            {"defence", 5},
            {"mAttack", 5},
            {"mDefence", 5},
            {"speed", 10},

        };
        player2 = new Dictionary<string, int>()
        {
            {"maxHP", 20},
            {"hp", 20},
            {"mp", 5},
            {"attack", 10},
            {"defence", 5},
            {"mAttack", 5},
            {"mDefence", 5},
            {"speed", 10},

        };
        /*
        player3 = new Dictionary<string, int>()
        {
            {"maxHP", 20},
            {"hp", 20},
            {"mp", 5},
            {"attack", 10},
            {"defence", 5},
            {"mAttack", 5},
            {"mDefence", 5},
            {"speed", 10},

        };
        */
        enemy1 = new Dictionary<string, int>()
        {
            {"maxHP", 10},
            {"hp", 10},
            {"mp", 0},
            {"attack", 5},
            {"defence", 0},
            {"mAttack", 0},
            {"mDefence", 0},
            {"speed", 5},

        };
        enemy2 = new Dictionary<string, int>()
        {
            {"maxHP", 10},
            {"hp", 10},
            {"mp", 0},
            {"attack", 5},
            {"defence", 0},
            {"mAttack", 0},
            {"mDefence", 0},
            {"speed", 5},

        };
        /*
        enemy3 = new Dictionary<string, int>()
        {
            {"maxHP", 10},
            {"hp", 10},
            {"mp", 0},
            {"attack", 5},
            {"defence", 0},
            {"mAttack", 0},
            {"mDefence", 0},
            {"speed", 5},

        };
        */
        //ステータスの登録されていないオブジェクトの削除
        if (player1 == null) GameObject.Find("Player1").SetActive(false);
        if (player2 == null) GameObject.Find("Player2").SetActive(false);
        if (player3 == null) GameObject.Find("Player3").SetActive(false);
        if (enemy1 == null) GameObject.Find("Enemy1").SetActive(false);
        if (enemy2 == null) GameObject.Find("Enemy2").SetActive(false);
        if (enemy3 == null) GameObject.Find("Enemy3").SetActive(false);
        //ステータス表示用オブジェクトの取得
        foreach (GameObject playerHP in GameObject.FindGameObjectsWithTag("PlayersHP"))
        {
            switch (playerHP.name.Substring(playerHP.name.Length - 1, 1))
            {
                case "1":
                    playerHPText1 = playerHP.GetComponent<Text>();
                    playerHPText1.text = player1["hp"].ToString();
                    break;
                case "2":
                    playerHPText2 = playerHP.GetComponent<Text>();
                    playerHPText2.text = player2["hp"].ToString();
                    break;
                case "3":
                    playerHPText3 = playerHP.GetComponent<Text>();
                    playerHPText3.text = player3["hp"].ToString();
                    break;

            }
        }
        foreach (GameObject enemyHP in GameObject.FindGameObjectsWithTag("EnemiesHP"))
        {
            switch (enemyHP.name.Substring(enemyHP.name.Length - 1, 1))
            {
                case "1":
                    enemyHPText1 = enemyHP.GetComponent<Text>();
                    enemyHPText1.text = enemy1["hp"].ToString();
                    break;
                case "2":
                    enemyHPText2 = enemyHP.GetComponent<Text>();
                    enemyHPText2.text = enemy2["hp"].ToString();
                    break;
                case "3":
                    enemyHPText3 = enemyHP.GetComponent<Text>();
                    enemyHPText3.text = enemy3["hp"].ToString();
                    break;

            }
        }
    }

    public void Attack()
    {
        Debug.Log(new TextController().GetText());
        //enemy1["hp"] -= player1["attack"];
        //enemyHPText1.text = enemy1["hp"].ToString();
    }
}
