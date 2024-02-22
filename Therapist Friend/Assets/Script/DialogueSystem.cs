using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
   public List<CharacterData> characters = new List<CharacterData>();
    public static DialogueSystem instance;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else Destroy(this);
    }
    public void NewMessage()
    {
        int choosenCharacter = Random.Range(0, characters.Count);
        characters[choosenCharacter].GetRandomDialogueSet();
        //get a random message from a random character every x seconds 
    }



}
