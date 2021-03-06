﻿namespace Shared.Network
{
    public enum SubPacketClientOpcode : ushort
    {
        None                                    = 0x0000,
        ClientCharacterList                     = 0x0003,
        ClientEnterWorld                        = 0x0004,
        ClientLobbyRequest                      = 0x0005,
        ClientCharacterDelete                   = 0x000A,
        ClientCharacterCreate                   = 0x000B,
        ClientNewWorld                          = 0x0066,
        ClientChat                              = 0x0067,
        ClientTerritoryFinalise                 = 0x0069,
        ClientLogout                            = 0x0074,
        ClientContentFinderRequestInfo          = 0x0078,
        ClientSocialInvite                      = 0x00AF, // 4.1
        ClientSocialInviteResponse              = 0x00A9,
        ClientSocialList                        = 0x00B3, // 4.1
        ClientPartyLeave                        = 0x00B1,
        ClientPartyDisband                      = 0x00B2,
        ClientPartyKick                         = 0x00B3,
        ClientPartyPromote                      = 0x00B4,
        ClientActorAction                       = 0x0111, // 4.1
        ClientGmCommandInt                      = 0x010C,
        ClientGmCommandString                   = 0x010D,
        ClientPlayerMove                        = 0x0118, // 4.1
        ClientInventoryAction                   = 0x011F, // 4.1
        ClientEventGossip                       = 0x0128, // 4.1
        ClientEventEmote                        = 0x0129, // 4.1
        ClientEventAreaTrigger                  = 0x012A, // 4.1
        ClientEventOutOfBounds                  = 0x012B, // 4.1
        ClientEventTerritory                    = 0x012C, // 4.1
        ClientEventSceneFinish                  = 0x0131  // 4.1
    }
}
