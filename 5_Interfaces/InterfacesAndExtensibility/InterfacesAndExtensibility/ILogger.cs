﻿using System;
namespace InterfacesAndExtensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
