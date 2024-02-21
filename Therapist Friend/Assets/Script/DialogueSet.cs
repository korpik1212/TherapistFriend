using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="DialogueSet")]
public class DialogueSet:ScriptableObject
{
    public List<Dialogue> question = new List<Dialogue>();
    public List<Answer> answers = new List<Answer>();

    
}
[System.Serializable]
public class Answer
{
    public string answer;
    public List<Dialogue> replyBack;
}
[System.Serializable]
public class Dialogue
{
    public string dialogueText;
}

