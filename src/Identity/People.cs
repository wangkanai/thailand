// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public class People
{
	public static List<Title> Titles { get; set; } =
	[
		new("นาย", "Mister", "นาย", "Mr."),
		new("นาง", "Mistress.", "นาง", "Mrs."),
		new("นางสาว", "Miss", "น.ส.", "Ms."),
		new("เด็กชาย", "Master", "ด.ช.", "Master"),
		new("เด็กหญิง", "Miss", "ด.ญ.", "Miss"),
	];
}
