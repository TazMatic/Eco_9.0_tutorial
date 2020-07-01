using System;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;


namespace Eco_9._0_tutorial
{
    public class Currency : IModKitPlugin, IServerPlugin
    {
        private Boolean started = false;

        public string GetStatus()
        {
            if (!started)
            {
                start();
                started = true;
            }
            return "";
        }
        public void start()
        {
            var test1 = new Listen();
            ActionUtil.AddListener(test1);
        }
    }
    public class Listen : IGameActionAware
    {
        public void ActionPerformed(GameAction action)
        {
            Console.WriteLine("action: " + action.MarkedUpName + "\n type: " + action.GetType());
            if (action.GetType() == typeof(DropOrPickupBlock))
            {
                Console.WriteLine("Match");
                DropOrPickupBlock tmp = (DropOrPickupBlock)action;
                //returns the block name
                Console.WriteLine("Block: " + tmp.ItemUsed.DisplayName);
                //return location of the block placed
                Console.WriteLine("Location: " + tmp.Location);
                //returns the username that placed the block
                Console.WriteLine("Username: " + tmp.Citizen.Name);
            }
        }

        public Result ShouldOverrideAuth(GameAction action)
        {
            throw new NotImplementedException();
        }
    }
}
