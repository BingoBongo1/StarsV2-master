using System;
namespace StarsV2
{
    internal class GameCore : IGameCore
    {
        private IGameControl gameControl;
        public GameCore(IGameControl gameControl)
        {
            this.gameControl = gameControl;
        }

        private void GameUI_OnKeyPressed(object sender, KeyEventArgs e)
        {
            gameControl.OnKeyUp(e);
            gameControl.OnKeyDown(e);
        }
        
    }
}
