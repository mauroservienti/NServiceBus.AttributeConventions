<img src="assets/icon.png" width="100" />

# NServiceBus.AttributeConventions.Contracts

Enables to configure NServiceBus messages, commands, and events conventions by using attributes on message types:

```
[Message]
public class SampleMessage
{}

[Command]
public class DoSomething
{}

[Event]
public class SomethingHappened
{}
```

> NOTE: Attributes are defined in a separate [NServiceBus.AttributeConventions.Contracts](https://github.com/mauroservienti/NServiceBus.AttributeConventions.Contracts) package to prevent coupling endpoints to the NServiceBus version this feature depends on.
> More information on [unobtrusive mode](https://docs.particular.net/nservicebus/messaging/unobtrusive-mode) can be found in the [NServiceBus documentation](https://docs.particular.net/nservicebus/messaging/unobtrusive-mode).

To configure the endpoint:

```
endpointConfiguration.UseAttributeConventions();
```

### Downloads

Nuget package: <https://www.nuget.org/packages/NServiceBus.AttributeConventions/>

---

Icon: [Handshake](https://thenounproject.com/search/?q=convention&i=302300) by [Bruno Landowski](https://thenounproject.com/bruno.landowski/) from [the Noun Project](https://thenounproject.com/)

