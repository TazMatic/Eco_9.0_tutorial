using System;
using Eco.Core.Controller;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Core.Utils.Threading;
using Eco.Gameplay;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Systems;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;

namespace Eco_9_0_tutorial
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
            //Do stuff here
        }
    }
}
