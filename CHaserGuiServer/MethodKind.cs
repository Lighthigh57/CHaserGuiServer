﻿using System;

namespace Oika.Apps.CHaserGuiServer
{
    public enum MethodKind
    {
        Unknown,
        Walk,
        Look,
        Search,
        Put,
    }

    public static class MethodKindExt
    {
        public static string ToWavPrefix(this MethodKind method)
        {
            switch (method)
            {
                case MethodKind.Unknown: return "";
                case MethodKind.Walk: return "walk";
                case MethodKind.Look: return "look";
                case MethodKind.Search: return "search";
                case MethodKind.Put: return "put";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string ToChar(this MethodKind method)
        {
            switch (method)
            {
                case MethodKind.Unknown: return "";
                case MethodKind.Walk: return "w";
                case MethodKind.Look: return "l";
                case MethodKind.Search: return "s";
                case MethodKind.Put: return "p";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
