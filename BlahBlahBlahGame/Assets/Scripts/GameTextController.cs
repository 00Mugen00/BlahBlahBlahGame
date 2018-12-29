using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextController : MonoBehaviour {

    [SerializeField]
    Text gameText;
    [SerializeField]
    State startingState;

    State currentState;

	void Start () {
        currentState = startingState;
        gameText.text = currentState.GetStateStory();
	}
	
	void Update () {
        State[] nextStates = currentState.GetNextState();
        for(int i=0; i<nextStates.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                currentState = nextStates[i];
            }
        }
        gameText.text = currentState.GetStateStory();
	}
}
