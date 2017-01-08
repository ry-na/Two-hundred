using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterModel : MonoBehaviour
{

    private Dictionary<string, int> status = new Dictionary<string, int>()
        {
            {"maxHP", 0},
            {"hp", 0},
            {"mp", 0},
            {"attack", 0},
            {"defence", 0},
            {"mAttack", 0},
            {"mDefence", 0},
            {"speed", 0},

        };
    public CharacterModel(Dictionary<string, int> status)
    {
        this.status = status;
    }
}
