﻿using System;

namespace MQTTnet.Diagnostics
{
    public interface IMqttNetLogger
    {
        event EventHandler<MqttNetLogMessagePublishedEventArgs> LogMessagePublished;

        IMqttNetChildLogger CreateChildLogger(string source);

        void Publish(MqttNetLogLevel logLevel, string source, string message, object[] parameters, Exception exception);
    }
}
