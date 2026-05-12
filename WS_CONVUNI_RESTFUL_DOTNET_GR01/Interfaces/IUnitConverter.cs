namespace WS_CONVUNI_RESTFUL_DOTNET_GR01.Interfaces;

public interface IUnitConverter<T> where T : struct
{
    double Convert(T from, T to, double value);
}