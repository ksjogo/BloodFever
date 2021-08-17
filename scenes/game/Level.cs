using Godot;
using KSGodot;

public class Level : Base
{
    [Export]
    public PackedScene ZombieTemplate;

    public Stick Stick;

    public Node UI()
    {
        return GetNode("UI");
    }

    public Actor Draco()
    {
        return GetNode<Actor>("actors/Draco");
    }

    public Node Actors()
    {
        return GetNode("actors");
    }

    public override void _Ready()
    {
        base._Ready();
        Stick = new Stick(GetNode("UI/Stick"));
    }

    public override void _Process(float delta)
    {
        base._Process(delta);
        Draco().LinearVelocity = Stick.Output() * 2;
    }

    public void OnSpawnTimer()
    {
        var mobSpawnLocation = GetNode<PathFollow2D>("SpawnPath/SpawnLocation");
        mobSpawnLocation.Offset = _random.Next();

        var mobInstance = (Actor)ZombieTemplate.Instance();
        Actors().AddChild(mobInstance);

        mobInstance.Position = mobSpawnLocation.Position;
    }
}
