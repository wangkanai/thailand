// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public static class Military
{
	public static List<ArmyRank> Army =>
	[
		new("พลเอก", "General", "พล.อ.", "Gen"),
		new("พลโท", "Lautent General", "พล.ท.","Lt Gen"),
		new("พลตรี", "Brigades General", "พล.ต.","Brig Gen"),
	];
}
