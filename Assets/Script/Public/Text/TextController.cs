using UnityEngine;
using System.Collections;

public class TextController : MonoBehaviour
{

    public string GetText()
    {
        TextAsset text = Resources.Load("test") as TextAsset;
        return text.text;
    }
}
