// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public sealed class NavyRank : Rank
{
	public NavyRank() { }

	public NavyRank(string titleThai, string titleEnglish, string abbreviationThai, string abbreviationEnglish)
	{
		TitleThai           = titleThai;
		TitleEnglish        = titleEnglish;
		AbbreviationThai    = abbreviationThai;
		AbbreviationEnglish = abbreviationEnglish;
	}
}
