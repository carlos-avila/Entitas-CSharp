![Entitas](https://raw.githubusercontent.com/sschmid/Entitas-CSharp/develop/Readme/Images/Entitas-Header.png)

***Entitas*** is a super fast Entity Component System Framework (ECS) specifically made for C# and Unity. Internal caching and blazing fast component access makes it second to none. Several design decisions have been made to work optimal in a garbage collected environment and to go easy on the garbage collector. ***Entitas*** comes with an optional code generator which radically reduces the amount of code you have to write and [makes your code read like well written prose.][clean-coders]

## Discover Entitas
Entitas is fast, light and gets rid of unnecessary complexity. There are less than a handful classes you have to know to rocket start your game or application:

- Entity
- Pool
- Group
- Group Observer

The optional code generator lets you write code that is super fast, safe and literally screams its intent. It radically reduces the amount of code you have to write and improves readability by a huge magnitude. It makes your code less error-prone while ensuring best performance. I strongly recommend using it!

Defining an entity is as simple as:
```csharp
public static Entity CreateRedGem(this Pool pool, int x, int y) {
    return pool.CreateEntity()
               .IsGameBoardElement(true)
               .IsMovable(true)
               .AddPosition(x, y)
               .AddResource(Res.redGem)
               .IsInteractive(true);
}
```

And you can access the created entity from anywhere in your application using matchers:
```csharp
var entities = pool.GetEntities(Matcher.AllOf(Matcher.Move, Matcher.Position));
foreach (var entity in entities) {
    var move = entity.move;
    var pos = entity.position;
    entity.ReplacePosition(pos.x, pos.y + move.speed);
}
```

The optional Unity module integrates Entitas nicely into Unity and provides powerful editor extensions to inspect and debug pools, groups, entities, components and systems.

![Unity Menu Item](https://raw.githubusercontent.com/sschmid/Entitas-CSharp/develop/Readme/Images/Entitas.Unity-MenuItems.png)
![Unity Visua Debugging Entity](https://raw.githubusercontent.com/sschmid/Entitas-CSharp/develop/Readme/Images/Entitas.Unity.VisualDebugging-Entity.png)
![Unity Visual Debugging Systems](https://raw.githubusercontent.com/sschmid/Entitas-CSharp/develop/Readme/Images/Entitas.Unity.VisualDebugging-DebugSystems.png)

## Requirements
!#TODO

## Installing

!#TODO

Each release is published with zip files attached containing all source files you need.

[**Entitas-CSharp.zip**][entitas-csharp-zip]

[**Entitas-Unity.zip**][entitas-unity-zip]

[Show releases][releases]

## Contributing


The project is hosted on [GitHub][github-entitas] where you can [report issues][issues], fork the project and [submit pull requests][pulls].

Entitas.sln contains all projects and tests in one solution. Run Build/build.sh to copy all required Entitas source files to all Unity projects.

To run the tests, navigate to the project root folder and execute runTests.sh.

- Check the [issues][issues] to make sure nobody hasn't already requested it and/or contributed it
- Fork the project
- Checkout the latest develop
- Start a feature/yourFeatureOrBugfix branch based on the latest develop
- Make sure to add/update tests. This is important so nobody will break it in a future version. Please write tests first, followed by the implementation.
- Commit and push until you are happy with your contribution
- Create a [pull request][pulls]


## Credits

Big thanks to [@mzaks][github-mzaks], [@cloudjubei][github-cloudjubei] and [@devboy][github-devboy] for endless hours of discussion and helping making Entitas awesome!

Maintainer(s):

- [@sschmid][github-sschmid]
- [@s_schmid][twitter-sschmid]
- [@entitas_csharp][twitter-entitas_csharp]


## Ports


Entitas is also available in the following programming languages:

- [C#](https://github.com/sschmid/Entitas-CSharp)
- [Swift](https://github.com/mzaks/Entitas-Swift)
- [C++](https://github.com/JuDelCo/Entitas-Cpp)
- [Objective-C](https://github.com/wooga/entitas)
- [Go](https://github.com/wooga/go-entitas)
- [F#](https://github.com/darkoverlordofdata/Bosco.ECS)
- [TypeScript](https://github.com/darkoverlordofdata/entitas-ts)
- [Java](https://github.com/Rubentxu/entitas-java)
- [Haskell](https://github.com/mhaemmerle/entitas-haskell)
- [Erlang](https://github.com/mhaemmerle/entitas_erl)
- [Clojure](https://github.com/mhaemmerle/entitas-clj)


[clean-coders]: https://cleancoders.com "Clean Coders"
[entitas-csharp-zip]: https://github.com/sschmid/Entitas-CSharp/blob/master/bin/Entitas-CSharp.zip?raw=true "Download Entitas-CSharp.zip"
[entitas-unity-zip]: https://github.com/sschmid/Entitas-CSharp/blob/master/bin/Entitas-Unity.zip?raw=true "Download Entitas-Unity.zip"

[wiki]: https://github.com/sschmid/Entitas-CSharp/wiki "Entitas Wiki"
[wiki-code-generator]: https://github.com/sschmid/Entitas-CSharp/wiki/Code-Generator "Wiki - Code Generator"
[wiki-overview]: https://github.com/sschmid/Entitas-CSharp/wiki/Overview "Wiki - Overview"
[wiki-unity-integration]: https://github.com/sschmid/Entitas-CSharp/wiki/Unity-integration "Wiki - Unity Integration"
[wiki-example-projects]: https://github.com/sschmid/Entitas-CSharp/wiki/Example-projects "Wiki - Example Projects"
[wiki-games-and-examples]: https://github.com/sschmid/Entitas-CSharp/wiki/Games-and-Examples "Wiki - Games and Examples #madeWithEntitas"

[unite-europe-2015-video-thumbnail]: https://raw.githubusercontent.com/sschmid/Entitas-CSharp/develop/Readme/Images/UniteEurope2015-Video.png "Video: Watch the Entitas Talk at Unite Europe 2015"
[unite-europe-2015-video]: http://buff.ly/1KtKlm6 "Video: Watch the Entitas Talk at Unite Europe 2015"

[github-entitas]: https://github.com/sschmid/Entitas-CSharp "sschmid/Entitas-CSharp"
[releases]: https://github.com/sschmid/Entitas-CSharp/releases "Releases"
[issues]: https://github.com/sschmid/Entitas-CSharp/issues "Issues"
[pulls]: https://github.com/sschmid/Entitas-CSharp/pulls "Pull Requests"

[twitter-sschmid]: https://twitter.com/s_schmid "s_schmid on Twitter"
[twitter-entitas_csharp]: https://twitter.com/entitas_csharp "entitas_csharp on Twitter"

[github-sschmid]: https://github.com/sschmid "@sschmid"
[github-mzaks]: https://github.com/mzaks "@mzaks"
[github-cloudjubei]: https://github.com/cloudjubei "@cloudjubei"
[github-devboy]: https://github.com/devboy "@devboy"