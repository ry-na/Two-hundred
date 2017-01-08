using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleController : MonoBehaviour {
    public CharacterModel player;
    public CharacterModel enemy;

    // Use this for initialization
    void Start () {
        player = new CharacterModel(new Dictionary<string, int>()
        {
            {"maxHP", 20},
            {"hp", 20},
            {"mp", 5},
            {"attack", 10},
            {"defence", 5},
            {"mAttack", 5},
            {"mDefence", 5},
            {"speed", 10},

        });
        enemy = new CharacterModel(new Dictionary<string, int>()
        {
            {"maxHP", 10},
            {"hp", 10},
            {"mp", 0},
            {"attack", 5},
            {"defence", 0},
            {"mAttack", 0},
            {"mDefence", 0},
            {"speed", 5},

        });
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
