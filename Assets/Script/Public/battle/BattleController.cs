using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class BattleController : MonoBehaviour
{
    public Canvas canvas;

    private Text playerHPText;
    private Text enemyHPText; 

    private Dictionary<string, int> player;
    private Dictionary<string, int> enemy;

    // Use this for initialization
    void Start()
    {
        player = new Dictionary<string, int>()
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
        enemy = new Dictionary<string, int>()
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
        foreach (Transform child in canvas.transform)
        {
            if (child.name == "PlayerStatus")
            {
                playerHPText = child.gameObject.GetComponent<Text>();
                playerHPText.text = player["hp"].ToString();
            }
            else if (child.name == "EnemyStatus")
            {
                enemyHPText = child.gameObject.GetComponent<Text>();
                enemyHPText.text = enemy["hp"].ToString();
            }
        }
    }

    public void Attack()
    {
        enemy["hp"] -= player["attack"];
        enemyHPText.text = enemy["hp"].ToString();
    }
}
