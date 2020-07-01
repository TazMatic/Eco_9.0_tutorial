using System;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;


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
            var test1 = new Listen();
            ActionUtil.AddListener(test1);
        }
    }
    public class Listen : IGameActionAware
    {
        public void ActionPerformed(GameAction action)
        {
            switch (action)
            {
                case DropOrPickupBlock dropOrPickupBlock:
                    Console.WriteLine("Case 1");
                    //returns the block name
                    Console.WriteLine("Block: " + dropOrPickupBlock.ItemUsed.DisplayName);
                    //return location of the block placed
                    Console.WriteLine("Location: " + dropOrPickupBlock.Location);
                    //returns the username that placed the block
                    Console.WriteLine("Username: " + dropOrPickupBlock.Citizen.Name);
                    break;
                case DigOrMine digOrMine:
                    Console.WriteLine("Case 2");
                    //returns the block name
                    Console.WriteLine("Block: " + digOrMine.ItemUsed.DisplayName);
                    //return location of the block placed
                    Console.WriteLine("Location: " + digOrMine.Location);
                    //returns the username that placed the block
                    Console.WriteLine("Username: " + digOrMine.Citizen.Name);
                    break;
                case HarvestOrHunt harvestOrHunt:
                    Console.WriteLine("Case 3");
                    //returns the plant name
                    Console.WriteLine("Block: " + harvestOrHunt.Species);
                    //return location of the block placed
                    Console.WriteLine("Location: " + harvestOrHunt.Location);
                    //returns the username that harvested the plant
                    Console.WriteLine("Username: " + harvestOrHunt.Citizen.Name);
                    break;
                case ChopTree chopTree:
                    Console.WriteLine("Case 4");
                    //returns the tree name
                    Console.WriteLine("Block: " + chopTree.TreeSpecies);
                    //return location of the tree being chopped
                    Console.WriteLine("Location: " + chopTree.Location);
                    //returns the username that chopped the tree
                    Console.WriteLine("Username: " + chopTree.Citizen.Name);
                    //Says if the tree has fallen or not
                    Console.WriteLine("Was Felled: " + chopTree.Felled);
                    break;
                case ChopStump chopStump:
                    Console.WriteLine("Case 5");
                    //returns the tree name
                    Console.WriteLine("Block: " + chopStump.TreeSpecies);
                    //return location of the tree being chopped
                    Console.WriteLine("Location: " + chopStump.Location);
                    //returns the username that chopped the tree
                    Console.WriteLine("Username: " + chopStump.Citizen.Name);
                    //returns if the stump was destroyed
                    Console.WriteLine("WasDestroyed: " + chopStump.Destroyed);
                    break;
                case Play play:
                    //TODO Research what this is used for
                    break;
                case OpenAction openAction:
                    //TODO Research what this is used for
                    break;
                case InventoryAction inventoryAction:
                    //TODO Research what this is used for
                    break;
                case ChatSent chatSent:
                    //TODO Research what this is used for
                    break;
                case FirstLogin firstLogin:
                    //TODO Research what this is used for
                    break;
                case PolluteAir polluteAir:
                    //TODO Research what this is used for
                    break;
                case DropGarbage dropGarbage:
                    //TODO Research what this is used for
                    break;
                case Timer timer:
                    //TODO Research what this is used for
                    break;
                case PlaceOrPickUpObject placeOrPickUpObject:
                    //TODO Research what this is used for
                    break;
                case TampRoad tampRoad:
                    //TODO Research what this is used for
                    break;
                case PlowField plowField:
                    //TODO Research what this is used for
                    break;
                case ConstructOrDeconstruct constructOrDeconstruct:
                    //TODO Research what this is used for
                    break;
                case ItemCraftedAction itemCraftedAction:
                    //TODO Research what this is used for
                    break;
                case CreateWorkOrder createWorkOrder:
                    //TODO Research what this is used for
                    break;
                case AddToWorkOrderAction addToWorkOrderAction:
                    //TODO Research what this is used for
                    break;
                case LaborWorkOrderAction laborWorkOrderAction:
                    //TODO Research what this is used for
                    break;
                case WorkOrderAction workOrderAction:
                    //TODO Research what this is used for
                    break;
                case CleanupTreeDebris cleanupTreeDebris:
                    //TODO Research what this is used for
                    break;
                case PlantSeeds plantSeeds:
                    //TODO Research what this is used for
                    break;
                case CharacterLevelUp characterLevelUp:
                    //TODO Research what this is used for
                    break;
                case SpecialtyLevelUp specialtyLevelUp:
                    //TODO Research what this is used for
                    break;
                case GainProfession gainProfession:
                    //TODO Research what this is used for
                    break;
                case GainSpecialty gainSpecialty:
                    //TODO Research what this is used for
                    break;
                case SkillAction skillAction:
                    //TODO Research what this is used for
                    break;
                case LostElection lostElection:
                    //TODO Research what this is used for
                    break;
                case WonElection wonElection:
                    //TODO Research what this is used for
                    break;
                case JoinOrLeaveElection joinOrLeaveElection:
                    //TODO Research what this is used for
                    break;
                case StartElection startElection:
                    //TODO Research what this is used for
                    break;
                case Vote vote:
                    //TODO Research what this is used for
                    break;
                case ElectionAction electionAction:
                    //TODO Research what this is used for
                    break;
                case ReceiveGovernmentFunds receiveGovernmentFunds:
                    //TODO Research what this is used for
                    break;
                case PayTax payTax:
                    //TODO Research what this is used for
                    break;
                case TransferMoney transferMoney:
                    //TODO Research what this is used for
                    break;
                case ClaimOrUnclaimProperty claimOrUnclaimProperty:
                    //TODO Research what this is used for
                    break;
                case PropertyTransfer propertyTransfer:
                    //TODO Research what this is used for
                    break;
                case DemographicChange demographicChange:
                    //TODO Research what this is used for
                    break;
                case Trade trade:
                    //TODO Research what this is used for
                    break;
                case CreateCurrency createCurrency:
                    //TODO Research what this is used for
                    break;
                case MintCurrency mintCurrency:
                    //TODO Research what this is used for
                    break;

                case FinanceAction FinanceAction:
                    //TODO Research what this is used for
                    break;
                case WorkableAction workableAction:
                    //TODO Research what this is used for
                    break;
                case BlockAddRemove blockAddRemove:
                    //TODO Research what this is used for
                    break;
                default:
                    Console.WriteLine("Default case: " + action.GetType());
                    break;
            }
        }

        public Result ShouldOverrideAuth(GameAction action)
        {
            throw new NotImplementedException();
        }
    }
}
