using System;

namespace VegasScriptAssignVideoEventFromAudioEvent
{
    internal class VegasHelperException: Exception { }
    internal class VegasHelperNotFoundTrackException: VegasHelperException { }
    internal class VegasHelperTrackUnselectedException: VegasHelperException { }
    internal class VegasHelperNoneEventsException: VegasHelperException { }
    internal class VegasHelperNotFoundOFXParameterException : VegasHelperException { }
    internal class VegasHelperNotFoundJimakuPrefixException : VegasHelperException { }
    internal class VegasHelperNotFoundDockerViewException : VegasHelperException { }
}
