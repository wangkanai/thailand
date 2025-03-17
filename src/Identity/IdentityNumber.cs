namespace Wangkanai.Thailand.Identity;

public sealed class IdentityNumber
{
	public ulong Number { get; private set; }
	public bool  Valid  { get; private set; }

	public IdentityNumber() { }
	public IdentityNumber(ulong number) => Number = number;
}
