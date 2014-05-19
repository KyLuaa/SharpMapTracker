using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpTibiaProxy.Domain
{
    public enum MessageClasses
    {
        NONE = 0x00,

        TALKTYPE_SAY = 0x01,
        TALKTYPE_WHISPER = 0x02,
        TALKTYPE_YELL = 0x03,
        PRIVATE_FROM = 0x04,
        PRIVATE_TO = 0x05,
        CHANNEL_MANAGEMENT = 0x06,
        CHANNEL = 0x07,
        CHANNEL_HIGHLIGHT = 0x08,
        TALKTYPE_SPELL = 0x09,
        NPC_FROM_START_BLOCK = 0x0A,//10.37
        NPC_FROM = 0x0B,
        NPC_TO = 0x0C,
        GAMEMASTER_BROADCAST = 0x0D,
        GAMEMASTER_CHANNEL = 0x0E,//10.37
        GAMEMASTER_PRIVATE_FROM = 0x0F,
        GAMEMASTER_PRIVATE_TO = 0x20,
        TALKTYPE_MONSTER_SAY = 0x22,
        TALKTYPE_MONSTER_YELL = 0x23,

        TALKTYPE_FIRST = TALKTYPE_SAY,
        TALKTYPE_LAST = GAMEMASTER_PRIVATE_TO,
        TALKTYPE_MONSTER_FIRST = TALKTYPE_MONSTER_SAY,
        TALKTYPE_MONSTER_LAST = TALKTYPE_MONSTER_YELL,

        STATUS_CONSOLE_BLUE = 0x04, /*Teal message in local chat*/
        STATUS_CONSOLE_RED = 0x0D, /*Red message in console*/
        STATUS_DEFAULT = 0x11, /*White message at the bottom of the game window and in the console*/
        STATUS_WARNING = 0x12, /*Red message in game window and in the console*/
        EVENT_ADVANCE = 0x13, /*White message in game window and in the console*/
        STATUS_SMALL = 0x14, /*White message at the bottom of the game window"*/
        INFO_DESCR = 0x15, /*Green message in game window and in the console*/
        DAMAGE_DEALT = 0x16,
        DAMAGE_RECEIVED = 0x17,
        HEALED = 0x18,
        EXPERIENCE = 0x19,
        DAMAGE_OTHERS = 0X1A,
        HEALED_OTHERS = 0x1B,
        EXPERIENCE_OTHERS = 0x1C,
        EVENT_DEFAULT = 0x1D, /*White message at the bottom of the game window and in the console*/
        LOOT = 0x1E, /*Green message in game window and in the console*/
        TRADE_NPC = 0x1F, /*Green message in game window and in the console*/
        EVENT_GUILD = 0x20, /*Green message in game window and in the console*/
        PARTY_MANAGEMENT = 0x21, /*Green message in game window and in the console*/
        PARTY = 0x22, /*Green message in game window and in the console*/
        EVENT_ORANGE = 0x23, /*Orange message in local chat*/
        STATUS_CONSOLE_ORANGE = 0x24, /*Orange message in local chat*/
        REPORT = 0x25, /*White message in game window and in the console*/
        HOTKEY_USE = 0x26, /*Green message in game window*/
        TUTORIAL_HINT = 0x27
    };
}
