namespace Wangkanai.Thailand.Identity.Identifier;

public static class IdentityNumberValidator
{
	public static bool Validate(this IdentityNumber id)
	{
		if (id.Number > 9_999_999_999_999)
			return false;

		var number = id.Number;
		var digits = new int[13];

		ReadOnlySpan<char> span = number.ToString();
		for (var i = 0; i < span.Length; i++)
		{
			digits[i] = span[i] - '0';
		}

		var sum = 0;
		for (var i = 0; i < 12; i++)
		{
			sum += digits[i] * (13 - i);
		}

		var mod        = sum % 11;
		var checkDigit = mod <= 1 ? 1 - mod : 11 - mod;

		return digits[12] == checkDigit;
	}
}
