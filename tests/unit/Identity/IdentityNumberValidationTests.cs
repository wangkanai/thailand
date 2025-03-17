// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Thailand.Identity;

namespace Wangkanai.Thailand.Identity;

public class IdentityNumberValidationTests
{
	[Fact]
	public void MoreThen13digits_ReturnsFalse()
	{
		ulong number = 12345678901234567890;
		Assert.False(IdentityNumber.Validate(number));
	}

	[Fact]
	public void LessThen13digits_ReturnsFalse()
	{
		ulong number = 0_123_456_789_012;
		Assert.False(IdentityNumber.Validate(number));
	}
}
