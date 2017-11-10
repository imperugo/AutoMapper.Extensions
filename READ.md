The scope of this library is to have something that I use in all my projects.
I don't want to copy it on any new project, so I decided to put it on NuGet.

If you like it, feel free to use it, otherwise if it hurts you because you don't like to have `MapTo<>()` extension method of the type `object` feel free to ignore this library without stress me :)

Moreover, if you think it is useful and you want to add some features, send your amazing PR.

To install it:

```
PM> Install-Package AutoMapper.Extensions
```

To use it:

```csharp
var myInstance = new User();
myInstance.Firstname = "Ugo";
myInstance.Lastname = "Lattanzi";
myInstance.Email = "imperugo@gmail.com";

var myDto = myInstance.MapTo<UserDto>();
```

of course it works also for collections:

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

var myDto = myList.MapTo<UserDto>();
```

Finally I've added some converts for:

```
DateTimeOffset => DateTime
Uri => String
```

You don't know what a Converter is? No worries, take a look [here](https://github.com/AutoMapper/AutoMapper/wiki/Custom-type-converters)