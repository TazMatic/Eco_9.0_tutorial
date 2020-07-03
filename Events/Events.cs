using System;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Systems.Chat;
using Eco.Shared.Services;

namespace Eco_9_0_tutorial.events
{
    public class ModName : IModKitPlugin, IServerPlugin
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
            //Register listener
            var listener = new Listen();
            ActionUtil.AddListener(listener);
        }
    }
    //Create the listener
    //The listener captures all game events adn it it on the developer to filter out the one they want
    public class Listen : IGameActionAware
    {
        public void ActionPerformed(GameAction action)
        {
            switch (action)
            {
                /*
                    ************Player Actions************
                */
                //Triggers everytime a message is sent
                case ChatSent chatSent:
                    break;
                //Triggers when a player remains logged in for a moment
                case Play play:
                    break;
                //Triggers when a player logs in for the first time
                case FirstLogin firstLogin:
                    break;
                //Triggers when an Item finishes crafting
                case ItemCraftedAction itemCraftedAction:
                    break;
                //Triggers when a player adds labor to a work order
                case LaborWorkOrderAction laborWorkOrderAction:
                    break;
                //Triggers when a player mines or digs
                case DigOrMine digOrMine:
                    break;
                //Triggers when a road block gets tamped with a road tool
                case TampRoad tampRoad:
                    break;
                //Triggers when a player plows a dirt block
                case PlowField plowField:
                    break;
                //Triggers when a player places a block
                case DropOrPickupBlock dropOrPickupBlock:
                    break;
                //Triggers when a player places a world object
                case PlaceOrPickUpObject placeOrPickUpObject:
                    break;
                //Triggers when a player hits a tree
                case ChopTree chopTree:
                    break;
                //Triggers when a player hits a stump
                case ChopStump chopStump:
                    break;
                //Triggers when a player opens an object interface
                case OpenAction openAction:
                    break;
                //Triggers when an item moves in an inventory
                case InventoryAction inventoryAction:
                    break;
                 //Triggers when a player collects tree debris
                case CleanupTreeDebris cleanupTreeDebris:
                    break;
                //Triggers when a player transfers owned property
                case PropertyTransfer propertyTransfer:
                    break;
                //Triggers when a player is added or removed from a demographic
                case DemographicChange demographicChange:
                    break;

                /*
                    ************Economy Actions************
                */
                //Triggers when a player recieves money from the goverment
                case ReceiveGovernmentFunds receiveGovernmentFunds:
                    break;
                //Triggers when a player pays a tax
                case PayTax payTax:
                    break;
                //Triggers when a player send money
                case TransferMoney transferMoney:
                    break;
                //Triggers when a player claim or unclaims land
                case ClaimOrUnclaimProperty claimOrUnclaimProperty:
                    break;
                //Triggers when a player creates a currency
                case CreateCurrency createCurrency:
                    break;
                //Triggers when a player mints a currency
                case MintCurrency mintCurrency:
                    break;
                //Triggers when a player exchanges items at a store
                case Trade trade:
                    break;
                //Triggers when a player accepts a loan
                case FinanceAction FinanceAction:
                    break;

                /*
                    ************Civics Actions************
                */
                //Triggers when a player loses an election
                case LostElection lostElection:
                    //TODO Research what this is used for
                    break;
                //Triggers when a player wins an election
                case WonElection wonElection:
                    //TODO Research what this is used for
                    break;
                //Triggers when a player joins or leaves an election
                case JoinOrLeaveElection joinOrLeaveElection:
                    //TODO Research what this is used for
                    break;
                //Triggers when an election is started
                case StartElection startElection:
                    //TODO Research what this is used for
                    break;
                //Triggers when a player votes on law or election
                case Vote vote:
                    break;

                /*
                    ************Skill related Actions************
                */
                //Triggers when a player gains a star
                case CharacterLevelUp characterLevelUp:
                    break;
                //Triggers when a player levels up a specialty
                case SpecialtyLevelUp specialtyLevelUp:
                    //TODO Research what this is used for
                    break;
                //Triggers when a player selects a new profession
                case GainProfession gainProfession:
                    break;
                //Triggers when a player selects a new specialty
                case GainSpecialty gainSpecialty:
                    break;


                /*
                    ************Plant related Actions************
                */
                //Triggers when a player harvests a plant or animal
                case HarvestOrHunt harvestOrHunt:
                    break;
                //Triggers when a player plants a seed
                case PlantSeeds plantSeeds:
                    break;

                /*
                    ************Construction related Actions************
                */
                //Triggers when a player adds an item to a work order
                case AddToWorkOrderAction addToWorkOrderAction:
                    //TODO Research what this is used for
                    break;
                //Triggers when a player creates a work order
                case CreateWorkOrder createWorkOrder:
                    //TODO Research what this is used for
                    break;
                //Triggers when a player crafts for a work order
                case WorkOrderAction workOrderAction:
                    break;
                //Triggers when a player places a block in a form
                case ConstructOrDeconstruct constructOrDeconstruct:
                    break;

                /*
                    ************Pollution related Actions************
                */
                //Triggers when pollution gets released
                case PolluteAir polluteAir:
                    break;
                //Triggers when a player drops garbage
                case DropGarbage dropGarbage:
                    break;

                /*
                    ************Base classes************
                */
                case ElectionAction electionAction:
                    break;
                case BlockAddRemove blockAddRemove:
                    break;
                case WorkableAction workableAction:
                    break;
                case SkillAction skillAction:
                    break;

                /*
                    ************Other Actions************
                */
                //currently not in the game
                /*case Timer timer:
                    //TODO Research what this is used for
                    break;*/
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
