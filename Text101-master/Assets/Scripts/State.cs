using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14,10)]  [SerializeField] string strStoryText;
    [SerializeField] State[] nextState;

    public string GetStateStory()
    {
        return strStoryText;
    }

    public State[] GetNextState()
    {
        return nextState;
    }
}
