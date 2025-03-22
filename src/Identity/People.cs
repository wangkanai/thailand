// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public class People
{
	public static List<Title> Titles =>
	[
		new("นาย", "นาย", "Mr."),
		new("นาง", "นาง", "Mrs."),
		new("นางสาว", "น.ส.", "Ms."),
		new("เด็กชาย", "ด.ช.", "Master"),
		new("เด็กหญิง", "ด.ญ.", "Miss"),
	];
}
