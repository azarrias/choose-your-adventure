using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] StateSO startingState;

    StateSO currentState;

    void Start()
    {
        SetCurrentState(startingState);
    }

    void Update()
    {
        ManageState();
    }

    void SetCurrentState(StateSO state)
    {
        currentState = state;
        storyText.text = currentState.StoryText;
    }

    private void ManageState()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        { 
            Application.Quit();
        }
        for (var i = 0; i < currentState.NextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                SetCurrentState(currentState.NextStates[i]);
            }
        }
    }
}
