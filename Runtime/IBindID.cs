namespace MontanGames.Data.Core
{
    public interface IID
    {
        public ulong ID { get; }
    }
    public interface IDataTypeID
    {
        public byte Type { get; }
    }
    public interface IBindID : IID, IDataTypeID
    {
        public int GetHashCode();
    }
}