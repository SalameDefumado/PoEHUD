﻿using System;
using System.Collections.Generic;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerStashTab : RemoteMemoryObject
    {
        public const int StructSize = 0x48;

        public NativeStringReader Name => GetObject<NativeStringReader>(Address + 0x8);
        //public int InventoryId => M.ReadInt(Address + 0x12);
        public uint Color => M.ReadUInt(Address + 0x2c);
        public InventoryTabPermissions MemberFlags => (InventoryTabPermissions)M.ReadUInt(Address + 0x30);
        public InventoryTabPermissions OfficerFlags => (InventoryTabPermissions)M.ReadUInt(Address + 0x34);
        public InventoryTabType TabType => (InventoryTabType)M.ReadUInt(Address + 0x38);
        public ushort DisplayIndex => M.ReadUShort(Address + 0x3c);
        //public ushort LinkedParentId => M.ReadUShort(Address + 0x26);
        //public InventoryTabMapSeries MapSeries => (InventoryTabMapSeries)M.ReadByte(Address + 0x28);
        public InventoryTabFlags Flags => (InventoryTabFlags)M.ReadByte(Address + 0x41);

        [Flags]
        public enum InventoryTabPermissions : uint
        {
            Add = 2,
            None = 0,
            Remove = 4,
            View = 1
        }

        public enum InventoryTabType : uint
        {
            Currency = 3,
            Divination = 6,
            Essence = 8,
            Fragment = 9,
            Map = 5,
            Normal = 0,
            Premium = 1,
            Quad = 7,
            Todo2 = 2,
            Todo4 = 4
        }

        [Flags]
        public enum InventoryTabFlags : byte
        {
            Hidden = 0x80,
            MapSeries = 0x40,
            Premium = 4,
            Public = 0x20,
            RemoveOnly = 1,
            Unknown1 = 0x10,
            Unknown2 = 2,
            Unknown3 = 8
        }

        /*
        public enum InventoryTabMapSeries : byte
        {
            Atlas_of_Worlds = 3,
            None = 0,
            Original = 1,
            The_Awakening = 2,
            War_for_the_Atlas = 4
        }
        */
    }
}