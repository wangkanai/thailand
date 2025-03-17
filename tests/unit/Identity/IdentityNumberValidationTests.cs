// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Thailand.Identity.Identifier;

namespace Wangkanai.Thailand.Identity;

public class IdentityNumberValidationTests
{
	[Fact]
	public void Validate_ValidIdentityNumber_ReturnsTrue()
	{
		var id = new IdentityNumber(1234567890123);
		Assert.True(id.Validate());
	}
}
