﻿using System.Collections.Generic;
using WebApi.Models;

namespace WebApi
{
    public interface IWebInformation
    {
        /// <summary>
        /// Gets the name of the dll.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the display name of the dll, typically used in UI contexts.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Gets a brief description of the dll.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the path to the executable file for the dll.
        /// </summary>
        string ExecutablePath { get; }

        /// <summary>
        /// Gets the version of the dll file.
        /// </summary>
        string Version { get; }
        
        /// <summary>
        /// Gets the icon path of the dll.
        /// </summary>
        string IconPath { get; }

        /// <summary>
        /// Gets the configurations of the dll. configurations are used to initialize web connection.
        /// </summary>
        List<WebConfig> Configurations { get; }
    }
}
