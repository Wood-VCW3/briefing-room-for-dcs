/*
==========================================================================
This file is part of Briefing Room for DCS World, a mission
generator for DCS World, by @akaAgar (https://github.com/akaAgar/briefing-room-for-dcs)

Briefing Room for DCS World is free software: you can redistribute it
and/or modify it under the terms of the GNU General Public License
as published by the Free Software Foundation, either version 3 of
the License, or (at your option) any later version.

Briefing Room for DCS World is distributed in the hope that it will
be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Briefing Room for DCS World. If not, see https://www.gnu.org/licenses/
==========================================================================
*/

using BriefingRoom4DCS.Template;

namespace BriefingRoom4DCS.GUI
{
    /// <summary>
    /// Static "toolbox" class which provides various methods for graphical user interfaces.
    /// </summary>
    public static class BriefingRoomGUITools
    {
        /// <summary>
        /// Returns a human-readable string for an enum value.
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetHumanReadableEnum(object enumValue)
        {
            if (enumValue == null) return "";

            if (enumValue is AircraftPayload)
            {
                switch ((AircraftPayload)enumValue)
                {
                    case AircraftPayload.AirToAir: return "Air-to-air";
                    case AircraftPayload.AirToGround: return "Air-to-ground";
                    case AircraftPayload.AntiShip: return "Anti-ship";
                }
            }
            else if (enumValue is Amount)
            {
                switch ((Amount)enumValue)
                {
                    case Amount.VeryLow: return "Very low";
                    case Amount.VeryHigh: return "Very high";
                }
            }
            else if (enumValue is AmountNR)
            {
                switch ((AmountNR)enumValue)
                {
                    case AmountNR.VeryLow: return "Very low";
                    case AmountNR.VeryHigh: return "Very high";
                }
            }
            else if (enumValue is Decade)
            {
                switch ((Decade)enumValue)
                {
                    case Decade.Decade1940: return "1940s";
                    case Decade.Decade1950: return "1950s";
                    case Decade.Decade1960: return "1960s";
                    case Decade.Decade1970: return "1970s";
                    case Decade.Decade1980: return "1980s";
                    case Decade.Decade1990: return "1990s";
                    case Decade.Decade2000: return "2000s";
                    case Decade.Decade2010: return "2010s";
                    case Decade.Decade2020: return "2020s";
                }
            }
            else if (enumValue is FogOfWar)
            {
                switch ((FogOfWar)enumValue)
                {
                    case FogOfWar.AlliesOnly: return "Allies only";
                    case FogOfWar.KnownUnitsOnly: return "Known units only";
                    case FogOfWar.SelfOnly: return "Self only";
                }
            }
            else if (enumValue is MissionOption)
            {
                switch ((MissionOption)enumValue)
                {
                    case MissionOption.EnableCivilianTraffic: return "Enable civilian traffic";
                    case MissionOption.ImperialUnitsForBriefing: return "Imperial units for briefing";
                    case MissionOption.InvertCountriesCoalitions: return "Invert countries coalitions on map";
                    case MissionOption.OnlySpawnInFriendlyCountries: return "Only spawn units in allied countries";
                    case MissionOption.RadioMessagesTextOnly: return "Text-only radio messages (no audio)";
                }
            }
            else if (enumValue is PlayerStartLocation)
            {
                switch ((PlayerStartLocation)enumValue)
                {
                    case PlayerStartLocation.ParkingCold: return "Parking, cold";
                    case PlayerStartLocation.ParkingHot: return "Parking, hot";
                    case PlayerStartLocation.Runway: return "On runway";
                }
            }
            else if (enumValue is RealismOption)
            {
                switch ((RealismOption)enumValue)
                {
                    case RealismOption.BirdStrikes: return "Bird strikes";
                    case RealismOption.DisableDCSRadioAssists: return "Disable DCS radio assists";
                    case RealismOption.HideLabels: return "Hide labels";
                    case RealismOption.NoBDA: return "Disable DCS battle damage assessment log";
                    case RealismOption.NoCheats: return "No cheats";
                    case RealismOption.NoCrashRecovery: return "No crash recovery";
                    case RealismOption.NoEasyComms: return "No easy comms";
                    case RealismOption.NoExternalViews: return "No external views";
                    case RealismOption.NoGameMode: return "No game mode";
                    case RealismOption.NoOverlays: return "No overlays";
                    case RealismOption.NoPadlock: return "No padlock";
                    case RealismOption.RandomFailures: return "Random failures";
                    case RealismOption.RealisticGEffects: return "Realistic G-effects";
                    case RealismOption.WakeTurbulence: return "Wake turbulence";
                }
            }
            else if (enumValue is TimeOfDay)
            {
                switch ((TimeOfDay)enumValue)
                {
                    case TimeOfDay.RandomDaytime: return "Random, daytime only";
                }
            }
            else if (enumValue is Wind)
            {
                switch ((Wind)enumValue)
                {
                    case Wind.LightBreeze: return "Light breeze";
                    case Wind.ModerateBreeze: return "Moderate breeze";
                    case Wind.StrongBreeze: return "Strong breeze";
                }
            }

            return enumValue.ToString();
        }
    }
}