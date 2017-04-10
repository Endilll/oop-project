﻿using System.Collections.Generic;
using System.Windows.Media;
using OopProjectMvvm.Models;

namespace OopProjectMvvm {
	public static class MyColorList {
		public static readonly Dictionary<string, MyColor> MyColors = new Dictionary<string, MyColor> {
			["AliceBlue"]            = new MyColor(Colors.AliceBlue, "AliceBlue"),
			["AntiqueWhite"]         = new MyColor(Colors.AntiqueWhite, "AntiqueWhite"),
			["Aqua"]                 = new MyColor(Colors.Aqua, "Aqua"),
			["Aquamarine"]           = new MyColor(Colors.Aquamarine, "Aquamarine"),
			["Azure"]                = new MyColor(Colors.Azure, "Azure"),
			["Beige"]                = new MyColor(Colors.Beige, "Beige"),
			["Bisque"]               = new MyColor(Colors.Bisque, "Bisque"),
			["Black"]                = new MyColor(Colors.Black, "Black"),
			["BlanchedAlmond"]       = new MyColor(Colors.BlanchedAlmond, "BlanchedAlmond"),
			["Blue"]                 = new MyColor(Colors.Blue, "Blue"),
			["BlueViolet"]           = new MyColor(Colors.BlueViolet, "BlueViolet"),
			["Brown"]                = new MyColor(Colors.Brown, "Brown"),
			["BurlyWood"]            = new MyColor(Colors.BurlyWood, "BurlyWood"),
			["CadetBlue"]            = new MyColor(Colors.CadetBlue, "CadetBlue"),
			["Chartreuse"]           = new MyColor(Colors.Chartreuse, "Chartreuse"),
			["Chocolate"]            = new MyColor(Colors.Chocolate, "Chocolate"),
			["Coral"]                = new MyColor(Colors.Coral, "Coral"),
			["CornflowerBlue"]       = new MyColor(Colors.CornflowerBlue, "CornflowerBlue"),
			["Cornsilk"]             = new MyColor(Colors.Cornsilk, "Cornsilk"),
			["Crimson"]              = new MyColor(Colors.Crimson, "Crimson"),
			["Cyan"]                 = new MyColor(Colors.Cyan, "Cyan"),
			["DarkBlue"]             = new MyColor(Colors.DarkBlue, "DarkBlue"),
			["DarkCyan"]             = new MyColor(Colors.DarkCyan, "DarkCyan"),
			["DarkGoldenrod"]        = new MyColor(Colors.DarkGoldenrod, "DarkGoldenrod"),
			["DarkGray"]             = new MyColor(Colors.DarkGray, "DarkGray"),
			["DarkGreen"]            = new MyColor(Colors.DarkGreen, "DarkGreen"),
			["DarkKhaki"]            = new MyColor(Colors.DarkKhaki, "DarkKhaki"),
			["DarkMagenta"]          = new MyColor(Colors.DarkMagenta, "DarkMagenta"),
			["DarkOliveGreen"]       = new MyColor(Colors.DarkOliveGreen, "DarkOliveGreen"),
			["DarkOrange"]           = new MyColor(Colors.DarkOrange, "DarkOrange"),
			["DarkOrchid"]           = new MyColor(Colors.DarkOrchid, "DarkOrchid"),
			["DarkRed"]              = new MyColor(Colors.DarkRed, "DarkRed"),
			["DarkSalmon"]           = new MyColor(Colors.DarkSalmon, "DarkSalmon"),
			["DarkSeaGreen"]         = new MyColor(Colors.DarkSeaGreen, "DarkSeaGreen"),
			["DarkSlateBlue"]        = new MyColor(Colors.DarkSlateBlue, "DarkSlateBlue"),
			["DarkSlateGray"]        = new MyColor(Colors.DarkSlateGray, "DarkSlateGray"),
			["DarkTurquoise"]        = new MyColor(Colors.DarkTurquoise, "DarkTurquoise"),
			["DarkViolet"]           = new MyColor(Colors.DarkViolet, "DarkViolet"),
			["DeepPink"]             = new MyColor(Colors.DeepPink, "DeepPink"),
			["DeepSkyBlue"]          = new MyColor(Colors.DeepSkyBlue, "DeepSkyBlue"),
			["DimGray"]              = new MyColor(Colors.DimGray, "DimGray"),
			["DodgerBlue"]           = new MyColor(Colors.DodgerBlue, "DodgerBlue"),
			["Firebrick"]            = new MyColor(Colors.Firebrick, "Firebrick"),
			["FloralWhite"]          = new MyColor(Colors.FloralWhite, "FloralWhite"),
			["ForestGreen"]          = new MyColor(Colors.ForestGreen, "ForestGreen"),
			["Fuchsia"]              = new MyColor(Colors.Fuchsia, "Fuchsia"),
			["Gainsboro"]            = new MyColor(Colors.Gainsboro, "Gainsboro"),
			["GhostWhite"]           = new MyColor(Colors.GhostWhite, "GhostWhite"),
			["Gold"]                 = new MyColor(Colors.Gold, "Gold"),
			["Goldenrod"]            = new MyColor(Colors.Goldenrod, "Goldenrod"),
			["Gray"]                 = new MyColor(Colors.Gray, "Gray"),
			["Green"]                = new MyColor(Colors.Green, "Green"),
			["GreenYellow"]          = new MyColor(Colors.GreenYellow, "GreenYellow"),
			["Honeydew"]             = new MyColor(Colors.Honeydew, "Honeydew"),
			["HotPink"]              = new MyColor(Colors.HotPink, "HotPink"),
			["IndianRed"]            = new MyColor(Colors.IndianRed, "IndianRed"),
			["Indigo"]               = new MyColor(Colors.Indigo, "Indigo"),
			["Ivory"]                = new MyColor(Colors.Ivory, "Ivory"),
			["Khaki"]                = new MyColor(Colors.Khaki, "Khaki"),
			["Lavender"]             = new MyColor(Colors.Lavender, "Lavender"),
			["LavenderBlush"]        = new MyColor(Colors.LavenderBlush, "LavenderBlush"),
			["LawnGreen"]            = new MyColor(Colors.LawnGreen, "LawnGreen"),
			["LemonChiffon"]         = new MyColor(Colors.LemonChiffon, "LemonChiffon"),
			["LightBlue"]            = new MyColor(Colors.LightBlue, "LightBlue"),
			["LightCoral"]           = new MyColor(Colors.LightCoral, "LightCoral"),
			["LightCyan"]            = new MyColor(Colors.LightCyan, "LightCyan"),
			["LightGoldenrodYellow"] = new MyColor(Colors.LightGoldenrodYellow, "LightGoldenrodYellow"),
			["LightGray"]            = new MyColor(Colors.LightGray, "LightGray"),
			["LightGreen"]           = new MyColor(Colors.LightGreen, "LightGreen"),
			["LightPink"]            = new MyColor(Colors.LightPink, "LightPink"),
			["LightSalmon"]          = new MyColor(Colors.LightSalmon, "LightSalmon"),
			["LightSeaGreen"]        = new MyColor(Colors.LightSeaGreen, "LightSeaGreen"),
			["LightSkyBlue"]         = new MyColor(Colors.LightSkyBlue, "LightSkyBlue"),
			["LightSlateGray"]       = new MyColor(Colors.LightSlateGray, "LightSlateGray"),
			["LightSteelBlue"]       = new MyColor(Colors.LightSteelBlue, "LightSteelBlue"),
			["LightYellow"]          = new MyColor(Colors.LightYellow, "LightYellow"),
			["Lime"]                 = new MyColor(Colors.Lime, "Lime"),
			["LimeGreen"]            = new MyColor(Colors.LimeGreen, "LimeGreen"),
			["Linen"]                = new MyColor(Colors.Linen, "Linen"),
			["Magenta"]              = new MyColor(Colors.Magenta, "Magenta"),
			["Maroon"]               = new MyColor(Colors.Maroon, "Maroon"),
			["MediumAquamarine"]     = new MyColor(Colors.MediumAquamarine, "MediumAquamarine"),
			["MediumBlue"]           = new MyColor(Colors.MediumBlue, "MediumBlue"),
			["MediumOrchid"]         = new MyColor(Colors.MediumOrchid, "MediumOrchid"),
			["MediumPurple"]         = new MyColor(Colors.MediumPurple, "MediumPurple"),
			["MediumSeaGreen"]       = new MyColor(Colors.MediumSeaGreen, "MediumSeaGreen"),
			["MediumSlateBlue"]      = new MyColor(Colors.MediumSlateBlue, "MediumSlateBlue"),
			["MediumSpringGreen"]    = new MyColor(Colors.MediumSpringGreen, "MediumSpringGreen"),
			["MediumTurquoise"]      = new MyColor(Colors.MediumTurquoise, "MediumTurquoise"),
			["MediumVioletRed"]      = new MyColor(Colors.MediumVioletRed, "MediumVioletRed"),
			["MidnightBlue"]         = new MyColor(Colors.MidnightBlue, "MidnightBlue"),
			["MintCream"]            = new MyColor(Colors.MintCream, "MintCream"),
			["MistyRose"]            = new MyColor(Colors.MistyRose, "MistyRose"),
			["Moccasin"]             = new MyColor(Colors.Moccasin, "Moccasin"),
			["NavajoWhite"]          = new MyColor(Colors.NavajoWhite, "NavajoWhite"),
			["Navy"]                 = new MyColor(Colors.Navy, "Navy"),
			["OldLace"]              = new MyColor(Colors.OldLace, "OldLace"),
			["Olive"]                = new MyColor(Colors.Olive, "Olive"),
			["OliveDrab"]            = new MyColor(Colors.OliveDrab, "OliveDrab"),
			["Orange"]               = new MyColor(Colors.Orange, "Orange"),
			["OrangeRed"]            = new MyColor(Colors.OrangeRed, "OrangeRed"),
			["Orchid"]               = new MyColor(Colors.Orchid, "Orchid"),
			["PaleGoldenrod"]        = new MyColor(Colors.PaleGoldenrod, "PaleGoldenrod"),
			["PaleGreen"]            = new MyColor(Colors.PaleGreen, "PaleGreen"),
			["PaleTurquoise"]        = new MyColor(Colors.PaleTurquoise, "PaleTurquoise"),
			["PaleVioletRed"]        = new MyColor(Colors.PaleVioletRed, "PaleVioletRed"),
			["PapayaWhip"]           = new MyColor(Colors.PapayaWhip, "PapayaWhip"),
			["PeachPuff"]            = new MyColor(Colors.PeachPuff, "PeachPuff"),
			["Peru"]                 = new MyColor(Colors.Peru, "Peru"),
			["Pink"]                 = new MyColor(Colors.Pink, "Pink"),
			["Plum"]                 = new MyColor(Colors.Plum, "Plum"),
			["PowderBlue"]           = new MyColor(Colors.PowderBlue, "PowderBlue"),
			["Purple"]               = new MyColor(Colors.Purple, "Purple"),
			["Red"]                  = new MyColor(Colors.Red, "Red"),
			["RosyBrown"]            = new MyColor(Colors.RosyBrown, "RosyBrown"),
			["RoyalBlue"]            = new MyColor(Colors.RoyalBlue, "RoyalBlue"),
			["SaddleBrown"]          = new MyColor(Colors.SaddleBrown, "SaddleBrown"),
			["Salmon"]               = new MyColor(Colors.Salmon, "Salmon"),
			["SandyBrown"]           = new MyColor(Colors.SandyBrown, "SandyBrown"),
			["SeaGreen"]             = new MyColor(Colors.SeaGreen, "SeaGreen"),
			["SeaShell"]             = new MyColor(Colors.SeaShell, "SeaShell"),
			["Sienna"]               = new MyColor(Colors.Sienna, "Sienna"),
			["Silver"]               = new MyColor(Colors.Silver, "Silver"),
			["SkyBlue"]              = new MyColor(Colors.SkyBlue, "SkyBlue"),
			["SlateBlue"]            = new MyColor(Colors.SlateBlue, "SlateBlue"),
			["SlateGray"]            = new MyColor(Colors.SlateGray, "SlateGray"),
			["Snow"]                 = new MyColor(Colors.Snow, "Snow"),
			["SpringGreen"]          = new MyColor(Colors.SpringGreen, "SpringGreen"),
			["SteelBlue"]            = new MyColor(Colors.SteelBlue, "SteelBlue"),
			["Tan"]                  = new MyColor(Colors.Tan, "Tan"),
			["Teal"]                 = new MyColor(Colors.Teal, "Teal"),
			["Thistle"]              = new MyColor(Colors.Thistle, "Thistle"),
			["Tomato"]               = new MyColor(Colors.Tomato, "Tomato"),
			["Transparent"]          = new MyColor(Colors.Transparent, "Transparent"),
			["Turquoise"]            = new MyColor(Colors.Turquoise, "Turquoise"),
			["Violet"]               = new MyColor(Colors.Violet, "Violet"),
			["Wheat"]                = new MyColor(Colors.Wheat, "Wheat"),
			["White"]                = new MyColor(Colors.White, "White"),
			["WhiteSmoke"]           = new MyColor(Colors.WhiteSmoke, "WhiteSmoke"),
			["Yellow"]               = new MyColor(Colors.Yellow, "Yellow"),
			["YellowGreen"]          = new MyColor(Colors.YellowGreen, "YellowGreen")
		};
	}
}
