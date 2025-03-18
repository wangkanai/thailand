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

	[Fact]
	public void DefaultConstructor_SetsNumberToZero()
	{
		var id = new IdentityNumber();
		Assert.Equal(0ul, id.Number);
	}

	[Theory]
	[InlineData(1102700009042ul)]  // Valid Thai ID
	[InlineData(0200123456782ul)]  // Valid Company ID
	public void Constructor_SetsNumberProperty(ulong number)
	{
		var id = new IdentityNumber(number);
		Assert.Equal(number, id.Number);
	}

	[Theory]
	[InlineData(1102700009042ul, true)]   // Valid Thai personal ID
	[InlineData(1100400758888ul, false)]  // Invalid checksum
	public void IsValid_ReturnsExpectedResult(ulong number, bool expected)
	{
		var id = new IdentityNumber(number);
		Assert.Equal(expected, id.IsValid);
	}

	[Theory]
	[InlineData(1102700009042ul, true)]   // Personal ID (starts with 1)
	[InlineData(9999999999999ul, true)]   // Personal ID (upper bound)
	[InlineData(1000000000000ul, true)]   // Personal ID (lower bound)
	[InlineData(0200123456782ul, false)]  // Company ID (starts with 0)
	public void IsPerson_ReturnsExpectedResult(ulong number, bool expected)
	{
		var id = new IdentityNumber(number);
		Assert.Equal(expected, id.IsPerson);
	}

	[Theory]
	[InlineData(0_200_123_456_782ul, true)]   // Company ID (starts with 0)
	[InlineData(9_999_999_999_999ul, false)]  // Personal ID (upper bound)
	[InlineData(0_200_000_000_000ul, true)]   // Company ID (lower bound)
	[InlineData(1_102_700_009_042ul, false)]  // Personal ID (starts with 1)
	public void IsCompany_ReturnsExpectedResult(ulong number, bool expected)
	{
		var id = new IdentityNumber(number);
		Assert.Equal(expected, id.IsCompany);
	}

	[Fact]
	public void IsCompany_And_IsPerson_AreMutuallyExclusive()
	{
		// Test with personal ID
		var personalId = new IdentityNumber(1_102_700_009_042ul);
		Assert.True(personalId.IsPerson); Assert.False(personalId.IsCompany);

		// Test with company ID
		var companyId = new IdentityNumber(0_200_123_456_782ul);
		Assert.False(companyId.IsPerson);
		Assert.True(companyId.IsCompany);
	}
}
