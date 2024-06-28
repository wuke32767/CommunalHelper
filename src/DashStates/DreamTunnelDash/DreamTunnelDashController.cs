using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using Monocle;

namespace Celeste.Mod.CommunalHelper.DashStates;

[CustomEntity("CommunalHelper/DreamTunnelDashController")]
[Tracked]
public class DreamTunnelDashController(EntityData e, Vector2 offset) : Entity()
{
    #region wip
    internal bool NeverSlowDown = e.Bool("neverSlowDown");
    internal bool OverrideDreamTunnelDashSpeed = e.Bool("OverrideDreamTunnelDashSpeed");
    internal float dreamTunnelDashSpeed = e.Float("dreamTunnelDashSpeed", 240f);

    internal bool allowSameDirectionDash = e.Bool("allowSameDirectionDash");
    internal bool allowDreamTunnelDashRedirect = e.Bool("allowDreamTunnelDashRedirect");
    internal bool allowNormalDashRedirect = e.Bool("allowNormalDashRedirect");

    internal bool UseEntrySpeedAngle = e.Bool("useEntrySpeedAngle");

    internal bool BounceOnCollision = e.Bool("bounceOnCollision");
    internal bool stickOnCollision = e.Bool("stickOnCollision");

    internal float sameDirectionSpeedMultiplier = e.Float("sameDirectionSpeedMultiplier", 1.0f);

    internal bool DreamBlockKillPlayer = e.Bool("DreamBlockKillPlayer", true);
    #endregion

}
