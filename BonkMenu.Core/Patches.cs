using System;
using MelonLoader;

namespace BonkMenu.Core;

public static class Patches
{
	public static void Apply()
	{
		// NOTE: Harmony patches are no longer used. SpawnEncounter now uses direct reflection.
		MelonLogger.Msg("[Patches] Skipping Harmony patches (using direct reflection instead)");
	}
}
