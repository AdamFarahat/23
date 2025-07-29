// Inherit from StateMachine
using UnityEngine;
using TwentyThree.Core;

// public class PlayerState
// {
//     protected Player player;
//     protected PlayerStateMachine stateMachine;
//     protected Animator animationController;
//     protected string animationName;

//     protected bool isExitingState;
//     protected bool isAnimationFinished;
//     protected float startTime;

//     public PlayerState(Player _player, PlayerStateMachine _stateMachine, Animator _animationController, string _animationName)
//     {
//         player = _player;
//         stateMachine = _stateMachine;
//         animationController = _animationController;
//         animationName = _animationName;
//     }

//     public virtual void Enter()
//     {
//         isAnimationFinished = false;
//         isExitingState = false;
//         startTime = Time.time;
//         animationController.SetBool(animationName, true);
//     }
//     public virtual void Exit()
//     {
//         isExitingState = true;
//         if (!isAnimationFinished) isAnimationFinished = true;
//         animationController.SetBool(animationName, false);
//     }
//     public virtual void LogicUpdate(){
//     TransitionChecks();
//     }
//     public virtual void PhysicsUpdate(){
//     }
//     public virtual void TransitionChecks(){
//     }
//     public virtual void AnimationTrigger(){
//     isAnimationFinished = true;
//     }
// }

