﻿using Celeste.Mod.Entities;
using Monocle;
using Microsoft.Xna.Framework;
using System;

namespace Celeste.Mod.MaxHelpingHand.Entities {
    [CustomEntity("MaxHelpingHand/RotatingBumper")]
    class RotatingBumper : Bumper {
        private Vector2 center;
        private readonly float radius;
        private readonly float speed; // in rad/s

        private float currentAngle;

        public RotatingBumper(EntityData data, Vector2 offset) : base(data.Position + offset, null) {
            Vector2 startingPosition = Position;

            center = data.NodesOffset(offset)[0];
            radius = (center - startingPosition).Length();
            speed = (float) (data.Float("speed", 360) * Math.PI / 180D);

            currentAngle = Calc.WrapAngle(Calc.Angle(center, startingPosition));

            if (data.Bool("attachToCenter")) {
                // attach center to any entity that is there.
                Add(new StaticMover {
                    SolidChecker = solid => CollideCheck(solid, center),
                    JumpThruChecker = jumpThru => CollideCheck(jumpThru, center),
                    OnMove = amount => center += amount
                });
            }
        }

        public override void Update() {
            base.Update();

            currentAngle += Engine.DeltaTime * speed;
            currentAngle = Calc.WrapAngle(currentAngle);

            Position = center + Calc.AngleToVector(currentAngle, radius);
        }
    }
}
