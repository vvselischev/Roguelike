﻿using Roguelike.Initialization;

namespace Roguelike
{
    /// <summary>
    /// An entry point to the game.
    /// If no parameters are passed, a random level is generated.
    /// Otherwise, the first parameter is considered a path to the file
    /// with the level information.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var startState = GetStartState(args);
            var stateManager = StateManager.GetInstance();
            stateManager.ChangeState(startState);
        }
        
        private static IGameState GetStartState(string[] args)
        {
            if (args.Length > 0)
            {
                return new PlayGameState(args[0]);
            }
            return new PlayGameState();
        }
    }
}
