using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class GameAction : ScriptableObject
{
    public UnityAction action;

    //Unity action cannot be called by other events. 
    public void Raise()
    {
        action.Invoke();
    }
}
