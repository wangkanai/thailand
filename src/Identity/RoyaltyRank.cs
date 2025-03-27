// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public sealed class RoyaltyRank : Rank
{
	public RoyaltyRank() { }

	public RoyaltyRank(string titleThai, string titleEnglish)
	{
		TitleThai      = titleThai;
		TitleEnglish   = titleEnglish;
	}
}
