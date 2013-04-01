﻿using System;
using NLog;
using NLog.Config;

public class LogCaptureBuilder
{
    [ThreadStatic] 
    public static string LastMessage;

    public static void Init()
    {
        var actionTarget = new ActionTarget
            {
                Action = _ => LastMessage = _.Message
            };
        var config = new LoggingConfiguration();
        config.LoggingRules.Add(new LoggingRule("*", LogLevel.Trace, actionTarget));
        config.AddTarget("debuger", actionTarget);
        LogManager.Configuration = config;
    }

}