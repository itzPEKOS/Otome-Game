using UnityEngine;

[CreateAssetMenu(fileName = "NewSpeaker", menuName = "Data/NewSpeaker")]

public class Speaker : ScriptableObject
{
    public string speakerName;
    public Color textColor;
}
