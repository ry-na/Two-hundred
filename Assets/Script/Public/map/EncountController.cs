using UnityEngine;
using System.Collections;

public class EncountController : MonoBehaviour {
    private int encountNum = 0;
    private float x = 0;
    private float z = 0; 


	// Use this for initialization
	void Start () {
        x = transform.position.x;
        z = transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {
        if (x != transform.position.x && z != transform.position.z) {
            encountNum += Random.Range(1, 10);
            if (encountNum >= 1500)
            {
                Encount();
                encountNum = 0;
            }
        }
        x = transform.position.x;
        z = transform.position.z;
    }

    private void Encount()
    {
        Debug.Log("えんかうんと");
    }
}
