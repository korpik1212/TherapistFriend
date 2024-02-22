using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Character")]
public class CharacterData : ScriptableObject
{

    public string chracterName;
    public Sprite icon;

    public List<DialogueSet> dialogueSets=new List<DialogueSet>();



    public DialogueSet GetRandomDialogueSet()
    {
        return  dialogueSets[Random.Range(0, dialogueSets.Count)];
    }




   
}
