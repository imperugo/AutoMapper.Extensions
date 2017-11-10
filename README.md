# Automappe.Extensions

The scope of this library is to have something that I use in all my projects.
I don't want to copy it on any new project, so I decided to put it on NuGet.

If you like it, feel free to use it, otherwise if it hurts you because you don't like to have `MapTo<>()` extension method of the type `object` feel free to ignore this library without stress me :)

Moreover, if you think it is useful and you want to add some features, send your amazing PR.

### Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [AutoMapper.Extensions](https://www.nuget.org/packages/AutoMapper.Extensions) from the package manager console:

```
PM> Install-Package AutoMapper.Extensions
```

### How do I get started?

#### Single instance:

```csharp
var myInstance = new User();
myInstance.Firstname = "Ugo";
myInstance.Lastname = "Lattanzi";
myInstance.Email = "imperugo@gmail.com";

var myDto = myInstance.MapTo<UserDto>();
```

#### Existing instance:

```csharp
var myInstance = new User();
myInstance.Firstname = "Ugo";
myInstance.Lastname = "Lattanzi";
myInstance.Email = "imperugo@gmail.com";

var myDto = new UserDto();

myInstance.MapToInstance(myDto);
```

#### Collection:

```csharp
var myList = new List<User>();
myList.Add(new User(){
    Firstname = "Ugo",
    Lastname = "Lattanzi",
    Email = "imperugo@gmail.com"
});

myList.Add(new User(){
    Firstname = "Mario",
    Lastname = "Rossi",
    Email = "xxx@yyy.com"
});

var myDtoList = myList.MapTo<UserDto>();
```

Finally I've added some converts for:

```
DateTimeOffset => DateTime
Uri => String
```

You don't know what a Converter is? No worries, take a look [here](https://github.com/AutoMapper/AutoMapper/wiki/Custom-type-converters)

## Contributing
**Getting started with Git and GitHub**

 * [Setting up Git for Windows and connecting to GitHub](http://help.github.com/win-set-up-git/)
 * [Forking a GitHub repository](http://help.github.com/fork-a-repo/)
 * [The simple guide to GIT guide](http://rogerdudler.github.com/git-guide/)
 * [Open an issue](https://github.com/imperugo/StackExchange.Redis.Extensions/issues) if you encounter a bug or have a suggestion for improvements/features


Once you're familiar with Git and GitHub, clone the repository and start contributing.