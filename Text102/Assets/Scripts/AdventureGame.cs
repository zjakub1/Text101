// namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // you need to use a specific namespace to have access to the user interface keyword
    // available within inspector - so you can make changes
    //[SerializeField] Text textComponent;
    [SerializeField] State startingState;
    // need this in order to be able to drag the TMP object into the component
    [SerializeField] TextMeshProUGUI storyText;


      
    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        //textComponent.fontSize = 40;
        //textComponent.text = state.GetStateStory();
        storyText.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        // shorthand when variable is declared and initialised
        // the method returns an array of states, so var has context
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }

        //textComponent.text = state.GetStateStory();
        storyText.text = state.GetStateStory();
    }
}
