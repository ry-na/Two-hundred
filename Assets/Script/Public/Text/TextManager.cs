using UnityEngine;
using System.Collections;

public class TextManager : MonoBehaviour
{

    public string GetTextAll(string name)
    {
        TextAsset text = Resources.Load(name) as TextAsset;
        return text.text;
    }

    public string GetTextOneStory(string name, string storyId)
    {
        TextAsset text = Resources.Load("test") as TextAsset;
        return text.text;
    }
}
