using UnityEngine;
using System.Collections;

public class BattleButton : MonoBehaviour
{

    public void OnClick()
    {
        if (transform.name == "Attack")
        {
            BattleController bController = transform.root.gameObject.GetComponent<BattleController>();
            bController.Attack();
        }
    }
}
