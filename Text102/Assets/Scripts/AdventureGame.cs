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
        
        // loop through the array
        // declare + initialisation, condition, increment
        // if index is < length of the array then iterate
        for (int index=0; index < nextStates.Length; index++)
        {
            // add the index to the keycode variable (for example alpha1 (1) plus index (0) still 1 so go to that index)
            // if alpha1 + 1 then = 2 that should be in the array so go to that scene object
            if(Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }

        //textComponent.text = state.GetStateStory();
        storyText.text = state.GetStateStory();
    }
}
