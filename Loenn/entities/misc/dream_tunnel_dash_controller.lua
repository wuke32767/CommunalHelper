local dreamTunnelDashController = {}

dreamTunnelDashController.name = "CommunalHelper/DreamTunnelDashController"
dreamTunnelDashController.depth = -1000000

dreamTunnelDashController.placements = {
    {
        name = "controller",
        data = {
            neverSlowDown = false,
            overrideDreamTunnelDashSpeed = false,
            dreamTunnelDashSpeed = 240,
            useEntrySpeedAngle = false,
            allowDreamTunnelDashRedirect = false,
            allowSameDirectionDash = false,
            allowNormalDashRedirect = false,
            sameDirectionSpeedMultiplier = 1.0,
        }
    }
}

dreamTunnelDashController.texture = "objects/CommunalHelper/dreamTunnelDashController/icon"

return dreamTunnelDashController
