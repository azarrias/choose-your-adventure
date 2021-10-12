using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/State")]
public class StateSO : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string storyText;
    public string StoryText => storyText;

    [SerializeField] StateSO[] nextStates;
    public StateSO[] NextStates => nextStates;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
