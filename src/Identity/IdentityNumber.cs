namespace Wangkanai.Thailand.Identity;

public sealed class IdentityNumber
{
	public ulong Number { get; private set; }

	public IdentityNumber() { }
	public IdentityNumber(ulong number) => Number = number;

	public bool IsValid => Validate(Number);

	public static bool Validate(ulong number)
	{
		if (number is > 9_999_999_999_999 or < 0_200_000_000_000)
			return false;

		var digits = new int[13];

		ReadOnlySpan<char> span = number.ToString();
		for (var i = 0; i < span.Length; i++)
			digits[i] = span[i] - '0';

		var sum = 0;
		for (var i = 0; i < 12; i++)
			sum += digits[i] * (13 - i);

		var mod        = sum % 11;
		var checkDigit = mod <= 1 ? 1 - mod : 11 - mod;
		var lastDigit  = digits[12];

		return lastDigit == checkDigit;
	}
}
