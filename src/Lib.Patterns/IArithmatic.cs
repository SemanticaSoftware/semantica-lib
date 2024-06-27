namespace Semantica.Patterns;

#if NET7_0_OR_GREATER
[Obsolete]
#endif
public interface IArithmatic<T> : IComparable<T>
{
    T Add(T other);
        
    T Subtract(T other);
        
    T Multiply(int factor);
}
