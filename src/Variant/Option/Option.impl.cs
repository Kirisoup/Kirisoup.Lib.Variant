namespace Kirisoup.Lib.Variant;

partial struct Option<T> 
{
	public bool IsSome => _isSome;
	public bool IsNone => !_isSome;

	public bool IsSomeAnd(Func<T, bool> predicate) => IsSome && predicate(_some);
	public bool IsNoneOr(Func<T, bool> predicate) => IsNone || predicate(_some);

	/// <param name="some">
	/// is valid only if method returned true, 
	/// otherwise zeroed or garbage data might be returned. 
	/// </param>
	public bool IsSomeThen(out T some) {
		some = _some;
		return IsSome;
	}
}
