// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public static class Monarchy
{
	public static List<RoyaltyRank> Royalty =>
	[
		new("พระมหากษัตริย์", "King"),
		new("พระราชินี", "Queen"),
		new("พระมเหสี", "Her Majesty Queen"),
		new("พระราชเทวี", "Royal Consort"),
		new("พระนางเธอ", "Royal Consort"),
		new("พระสนมเอก", "Royal Concubine"),
		new("พระสนม", "Concubine"),
		new("สยามมกุฎราชกุมาร", "Crown Prince"),
		new("สยามมกุฎราชกุมารี", "Princess Royal"),
		new("พระราชโอรส", "Prince"),
		new("พระราชธิดา", "Princess"),
	];

	public static List<RoyalDescendentRank> Descendent =>
	[
		new("หม่อมเจ้า", "King's Grandchild", "ม.จ.", "M.C."),
		new("หม่อมราชวงศ์", "King's Great-grandchild", "ม.ร.ว.", "M.R."),
		new("หม่อมหลวง", "Lord/Lady", "ม.ล.", "M.L."),
	];
}
