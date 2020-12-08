﻿using RSBot.Chat.Views;
using RSBot.Core;
using RSBot.Core.Plugins;
using System.Windows.Forms;

namespace RSBot.Chat
{
    public class Bootstrap : IPlugin
    {
        /// <summary>
        /// Gets or sets the information of the plugin.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        public PluginInfo Information => new PluginInfo
        {
            InternalName = "RSBot.Chat",
            DisplayAsTab = true,
            DisplayName = "Chat",
            LoadIndex = 101,
            TabDisplayIndex = 8
        };

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            Views.View.Instance = new Main();

            Log.Notify("Plugin [Chat] initialized!");
        }

        /// <summary>
        /// Gets the view that will be displayed as tab page.
        /// </summary>
        public Control GetView()
        {
            return Views.View.Instance;
        }
    }
}