using Godot;
using System;

public class Ball : KinematicBody2D
{
    [Export]
    private float movementVelocity = 5;

    private Vector2 movementDirection = Vector2.Up;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    public override void _PhysicsProcess(float delta)
    {
        KinematicCollision2D collider = MoveAndCollide(movementVelocity * movementDirection);
        if (collider != null)
        {
            if (collider.Collider is Brick)
            {
                Brick brick = (Brick)collider.Collider;
                brick.onBrickHitted();
            }

            if (collider.Collider is Racket)
            {
                Racket racket = (Racket)collider.Collider;
                Vector2 div = racket.onRacketHitted(collider.Position);
                movementDirection = (div + movementDirection.Bounce(collider.Normal)).Normalized();
            }
            else
                movementDirection = movementDirection.Bounce(collider.Normal);
        }
    }
}
