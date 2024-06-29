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
        }
    }
}

dreamTunnelDashController.texture="objects/CommunalHelper/dreamTunnelDashController/icon"

return dreamTunnelDashController
