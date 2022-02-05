using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    [SerializeField] Text textElement;
    [SerializeField] Text[] options = new Text[4];
    [SerializeField] State startState;
    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startState;
        textElement.text = state.GetStateText();
    }

    // Update is called once per frame
    void Update()
    {
        GameMain();
    }

    // Used to respond to user input
    private void GameMain()
    {
        State[] statesArray = state.GetOtherStates();
        SetState(statesArray);
        SetOptionsText(statesArray);
        textElement.text = state.GetStateText();
    }

    // Change the state according to player input
    private void SetState(State[] statesArray)
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && statesArray[0] != null)
        {
            state = statesArray[0];
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && statesArray[1] != null)
        {
            state = statesArray[1];
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && statesArray[2] != null)
        {
            state = statesArray[2];
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && statesArray[3] != null)
        {
            state = statesArray[3];
        }
    }
    
    // Change the options according to what the state is currently
    private void SetOptionsText(State[] statesArray)
    {
        options[0].text = statesArray[0] != null ? statesArray[0].name : "";
        options[1].text = statesArray[1] != null ? statesArray[1].name : "";
        options[2].text = statesArray[2] != null ? statesArray[2].name : "";
        options[3].text = statesArray[3] != null ? statesArray[3].name : "";
    }
}
