using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : IPlayerState
{
    public void Enter(Player player)
    {
        player.mCurrentState = new StandingState();
        Debug.Log("Entered: Standing State");
    }

    public void Execute(Player player)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            JumpingState jumpingState = new JumpingState();
            jumpingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            DuckingState duckingState = new DuckingState();
            duckingState.Enter(player);
        }
    }
}
