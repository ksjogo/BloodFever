using Godot;

public class Lifebar : Node2D
{
    [Export]
    public int Health = 100;

    [Export]
    public int HealthIncome = 0;


    public TextureProgress Bar()
    {
        return GetNode<TextureProgress>("Bar");
    }

    public override void _Process(float delta)
    {
        base._Process(delta);
        Health += HealthIncome;

        HealthIncome = 0;
        Bar().Value = Health;
    }
}
