﻿namespace RSBot.Bot.Default.Bundle
{
    internal interface IBundle
    {
        /// <summary>
        /// Invokes this instance.
        /// </summary>
        void Invoke();

        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        void Refresh();
    }
}