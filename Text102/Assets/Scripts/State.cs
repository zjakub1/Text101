using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// creates a menu option when you are amending 
[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    // serialzefield allows access of variable within unity inspector
    // 10 size of text box, 20 start to scroll when you hit this number of lines
    [TextArea(10,20)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
