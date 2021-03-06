﻿using Logger = Rocket.Core.Logging.Logger;
using Rocket.Core.Plugins;
using System;
using Rocket.API.Collections;

namespace NEXIS.Vaults
{
    public class Vault : RocketPlugin<VaultConfiguration>
    {
        public static Vault Instance;
        public DatabaseManager Database;

        protected override void Load()
        {
            Instance = this;
            Database = new DatabaseManager();
            Logger.Log("Vaults have been successfully loaded!", ConsoleColor.Yellow);
        }

        protected override void Unload()
        {
            Logger.Log("Vaults have been successfully unloaded!", ConsoleColor.Yellow);
        }

        public void FixedUpdate()
        {
        }

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList() {
                    {"vault_disabled", "Whoops! Sorry, but Vaults are currently disabled. ='("},
                    {"vault_invalid_item", "You do not have that item! You can only Vault items in your inventory."},
                    {"vault_action_invalid", "Invalid action! Type \"/vault help\" for more information."},
                    {"vault_params_invalid", "Invalid parameters! Type \"/vault help\" for more information."},
                    {"vault_opened", "You open a Vault and receive the contents inside!"},
                    {"vault_opened_error", "There was an error opening your Vault!"},
                    {"vault_saved", "You have saved an item to your Vault!"},
                    {"vault_saved_inventory", "You saved all items to your Vault!"},
                    {"vault_saved_error", "There was an error saving your Vault!"},
                    {"vault_saved_noitems", "You don't have any items to save!"},
                    {"vault_full", "All of your Vaults are full! You must first clear your vault by typing: /vault delete"},
                    {"vault_empty", "No Vault exists for you to open! You must save some items first."},
                    {"vault_delete_empty", "You have no Vaults to delete! Try saving one first: /vault save"},
                    {"vault_deleted", "You have deleted a Vault!"}
                };
            }
        }

    }

}