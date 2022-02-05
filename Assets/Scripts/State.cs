using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField][TextArea()] string gameText;
    [SerializeField] State[] otherStates;

    // return the game text for that state
    public string GetStateText()
    {
        return gameText;
    }

    public State[] GetOtherStates()
    {
        return otherStates;
    }
}
