using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStateMachine : MonoBehaviour
{
    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = BattleStates.START;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
        switch (currentState)
        {
            case BattleStates.START:
                currentState = BattleStates.PLAYERCHOICE;
                break;
            case BattleStates.PLAYERCHOICE:
                currentState = BattleStates.ENEMYCHOICE;
                break;
            case BattleStates.ENEMYCHOICE:
                currentState = BattleStates.LOSE;
                break;
            case BattleStates.LOSE:
                currentState = BattleStates.WIN;
                break;
            case BattleStates.WIN:
                currentState = BattleStates.START;
                break;
            default:
                break;
        }
        
    }
}
