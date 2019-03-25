# A Sample for Azure Function App IoT Hub integration

1. Go to IoT Hub -> {Your IoT Hub} -> Built-in endpoints.
2. Add a new consumer group as "FuncGroup".
3. Copy the value of Event Hub-compatible endpoint.
4. Go to Function App -> {Your Function App} -> Application settings.
5. In Application settings section, add a key as "IoTHubTriggerConnection", and paste the Event Hub-compatible endpoint value as its value.

For local debugging, use a local.settings.json file. Add a key.value as below:
"IoTHubTriggerConnection": "{Replace with your connection string}"