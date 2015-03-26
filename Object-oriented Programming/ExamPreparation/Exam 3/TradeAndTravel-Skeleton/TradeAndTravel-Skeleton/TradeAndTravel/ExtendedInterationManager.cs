using System;
using System.Collections.Generic;
using System.Linq;

namespace TradeAndTravel
{
    public class ExtendedInterationManager : InteractionManager
    {
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    person = base.CreatePerson(personTypeString, personNameString, personLocation); //???
                    break;
            }
            return person;
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item); // !?!
                    break;
            }
            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "forest":
                    location = new Forest(locationName);
                    break;
                case "mine":
                    location = new Mine(locationName);
                    break;
                default:
                    location = base.CreateLocation(locationTypeString, locationName);
                    break;
            }
            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    {
                        string itemName = commandWords[2];
                        HandleGatherInteraction(actor, itemName);
                        break;
                    }
                case "craft":
                    {
                        string itemType = commandWords[2];
                        string itemName = commandWords[3];
                        HandleCraftInteraction(actor, itemType, itemName);
                        break;
                    }
                default:
                        base.HandlePersonCommand(commandWords, actor);
                        break;
            }
        }

        public void HandleGatherInteraction(Person actor, string itemName)
        {
            bool canGatherItem = false;
            var currentLocation = actor.Location as IGatheringLocation;
            if (currentLocation != null)
	        {
                canGatherItem = actor.ListInventory().Any(it => it.ItemType == currentLocation.RequiredItem);
                if (canGatherItem)
                {
                    var item = currentLocation.ProduceItem(itemName);
                    this.AddToPerson(actor, item);
                    item.UpdateWithInteraction("gather");   
                }
	        }
        }

        public void HandleCraftInteraction(Person actor, string itemType, string itemName)
        {
            switch(itemType)
            {
                case "weapon":
                    CraftWeapon(actor, itemName);
                    break;
                case "armor":
                    CraftArmor(actor, itemName);
                    break;
            }
        }

        public void CraftWeapon(Person actor, string itemName)
        {
            var inventory = actor.ListInventory();
            bool canCraft = inventory.Any(it => it.ItemType == ItemType.Iron) && inventory.Any(it => it.ItemType == ItemType.Wood);

            if (canCraft)
            {
                this.AddToPerson(actor, new Weapon(itemName));
            }
        }

        public void CraftArmor(Person actor, string itemName)
        {
            var inventory = actor.ListInventory();
            bool canCraft = canCraft = inventory.Any(it => it.ItemType == ItemType.Iron);

            if (canCraft)
            {
                this.AddToPerson(actor, new Armor(itemName));
            }
        }
    }
}
