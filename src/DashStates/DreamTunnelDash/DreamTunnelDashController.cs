using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using Monocle;

namespace Celeste.Mod.CommunalHelper.DashStates;

[CustomEntity("CommunalHelper/DreamTunnelDashController")]
[Tracked]
public class DreamTunnelDashController(EntityData e, Vector2 offset) : Entity()
{
    internal bool NeverSlowDown = e.Bool("neverSlowDown");
    internal bool OverrideDreamTunnelDashSpeed = e.Bool("overrideDreamTunnelDashSpeed");
    internal float dreamTunnelDashSpeed = e.Float("dreamTunnelDashSpeed", 240f);

    internal bool UseEntrySpeedAngle = e.Bool("useEntrySpeedAngle");

    internal float calculateStartSpeed(float player = 0)
    {
        float target = DreamTunnelDash.Player_DashSpeed;
        if (OverrideDreamTunnelDashSpeed)
        {
            target = dreamTunnelDashSpeed;
        }
        if (NeverSlowDown && Math.Abs(target) < player)
        {
            target = Math.Sign(target) * player;
        }
        return target;
    }
    internal bool allowDreamTunnelDashRedirect = e.Bool("allowDreamTunnelDashRedirect");
    internal bool allowSameDirectionDash = e.Bool("allowSameDirectionDash");
    internal bool allowNormalDashRedirect = e.Bool("allowNormalDashRedirect");
    internal float sameDirectionSpeedMultiplier = e.Float("sameDirectionSpeedMultiplier", 1.0f);


    #region wip

    internal bool BounceOnCollision = e.Bool("bounceOnCollision");
    internal bool stickOnCollision = e.Bool("stickOnCollision");

    internal bool DreamBlockKillPlayer = e.Bool("DreamBlockKillPlayer", true);
    #endregion

}
