Understanding Dependency Injection 🧠
At its core, Dependency Injection is about removing the hard-coded dependencies and instead injecting them at runtime, allowing our application to be more flexible and easier to maintain. .NET Core has built-in support for DI, making it a first-class citizen in the framework.

Basic Concepts:
Service Container (or DI Container): A catalog of services and their corresponding implementations. It’s responsible for creating instances of types and managing their lifetimes.
Lifetime Management: Services can have different lifetimes:
Transient: A new instance is created every time a service is requested.
Scoped: A single instance is created per request.
Singleton: A single instance is created and shared throughout the application’s lifetime.

You can find more on this link:
https://medium.com/@dayanandthombare/dependency-injection-di-in-net-core-5ff37cf46887
