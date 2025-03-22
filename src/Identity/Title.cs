// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Thailand.Identity;

public sealed record Title
{
	public string Name    { get; }
	public string Thai    { get; }
	public string English { get; }

	public Title() { }

	public Title(string name, string thai, string english)
	{
		Name    = name;
		Thai    = thai;
		English = english;
	}
}
