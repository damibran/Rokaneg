using Godot;
using System;

public class Racket : KinematicBody2D
{
    [Export]
    private float movementVelocity = 10;

    [Export(PropertyHint.Range , "0,90,2")]
    private float spreadAngle=80;

    private Vector2 movementDirection;

    private float RacketWidth = 128;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    public override void _Input(InputEvent inputEvent)
    {
        if (Input.IsActionPressed("left"))
        {
            movementDirection = Vector2.Left;
        }
        else if (Input.IsActionPressed("right"))
        {
            movementDirection = Vector2.Right;
        }
        else
            movementDirection = Vector2.Zero;
    }

    public override void _PhysicsProcess(float delta)
    {
        MoveAndCollide(movementVelocity * movementDirection);
    }

    // returns deviation in bounce vector
    public Vector2 onRacketHitted(Vector2 collisionPos)
    {
        float diff = collisionPos.x - Position.x;
        float halfWidth = RacketWidth / 2.0f;
        float k = diff/halfWidth;
        Vector2 res = Vector2.Up;
        return res.Rotated(Mathf.Deg2Rad(spreadAngle)* k);
    }
}
