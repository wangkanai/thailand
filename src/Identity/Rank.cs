// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public abstract class Rank
{
	public Rank() { }

	public Rank(string titleThai, string titleEnglish, string abbreviationThai, string abbreviationEnglish)
	{
		TitleThai           = titleThai;
		TitleEnglish        = titleEnglish;
		AbbreviationThai    = abbreviationThai;
		AbbreviationEnglish = abbreviationEnglish;
	}

	public string TitleThai           { get; set; }
	public string TitleEnglish        { get; set; }
	public string AbbreviationThai    { get; set; }
	public string AbbreviationEnglish { get; set; }
}
