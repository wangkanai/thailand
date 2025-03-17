// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

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

	[Fact]
	public void NumbersBelowMinimum_ReturnsFalse()
	{
		ulong number = 0_100_000_000_000; // Below minimum (0_200_000_000_000)
		Assert.False(IdentityNumber.Validate(number));
	}


	[Theory]
	[InlineData(1234567890123ul, false)] // Random invalid number
	[InlineData(1100400758888ul, false)] // Invalid checksum
	[InlineData(1102700009042ul, true)]  // Valid Thai ID
	[InlineData(5100900000007ul, true)]  // Valid Thai ID starting with 5
	public void ValidateChecksum_ReturnsExpectedResult(ulong number, bool expected)
	{
		Assert.Equal(expected, IdentityNumber.Validate(number));
	}



}
